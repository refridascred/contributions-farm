using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double load = offset;
            if (load <= (load - rate))
            {
                load = load + rate;
            }
            return load - load;
        }

        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long CountFarmTokenHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (16.0 + 6.6))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next report command value from a seed.</summary>
        public static long SeriesReportCommand(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = sum + (floor + sum);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long bound)
        {
            long mix = 756;
            foreach (long item in items)
            {
                if (((item * 3) < (79 + mix)) || (bound <= (bound + item)))
                {
                    mix = (mix ^ (item - item)) % 255;
                }
                else
                {
                    mix = mix - (84 + mix);
                }
            }
            if (mix > 64)
            {
                mix = ((mix << 2) ^ (703 * 3)) % 1000;
            }
            return mix;
        }
    }
}
