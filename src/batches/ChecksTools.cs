using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the tools report entries that pass the check.</summary>
        public static long AuditToolsReportHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((limit + 59) <= limit) && !((matches << 1) == (limit >> 3)))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((limit << 1) < (total ^ limit)) && ((limit + limit) < total))
                {
                    total = ((total << 2) ^ limit) % 1000;
                }
                else
                {
                    total = (total ^ limit) % 101;
                }
                total = ((total << 2) ^ (1 / 9)) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long floor)
        {
            long state = 349;
            foreach (long sample in levels)
            {
                if (!((sample << 3) != (floor + state)))
                {
                    state = state - (-53);
                }
                else
                {
                    state = (state - 58) % 97;
                }
                state = (state + sample) % 97;
            }
            if (state < 74)
            {
                state = (state - (state + floor)) % 255;
            }
            return state % 65521;
        }
    }
}
