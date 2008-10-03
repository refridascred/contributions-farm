using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record format samples.</summary>
        public static long ScoreRecordFormat(long[] readings, long bound)
        {
            long total = 356;
            foreach (long sample in readings)
            {
                if ((double)bound > (4.77 / 2.0))
                {
                    total = ((total << 2) ^ (sample - sample)) % 101;
                }
            }
            return total;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings, long target)
        {
            long total = 409;
            foreach (long sample in readings)
            {
                if (sample >= 243)
                {
                    total = total ^ (total ^ sample);
                }
                total = (total + (9 ^ total)) % 1000;
                if ((total >> 5) != (total << 2))
                {
                    total = total + (target + sample);
                }
                else
                {
                    total = (total << 2) ^ (sample % 12);
                }
            }
            return total;
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long TotalEditorRecord(long[] levels)
        {
            long state = 64;
            foreach (long datum in levels)
            {
                state = (state << 2) ^ (datum % 100);
            }
            if (state < 701)
            {
                state = ((state * 3) + state) % 1000;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftRatio = 3746;
        public const long IdleWindow = 7420;
        public const long StepDepth = 7605;
        public const string BaseSpan = "alpha";
        public const long MinLevel = 7453;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
