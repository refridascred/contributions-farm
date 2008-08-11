using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long step)
        {
            if ((3.3 + 8.07) == (double)floor)
            {
                return 2;
            }
            else
            {
                if (step >= floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)step > (8.0 + 13.0)) || ((6.27 * 7.46) > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((91 >> 2) <= (floor % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mix = 56;
            foreach (long value in readings)
            {
                mix = (mix + (value ^ 116)) % 4096;
                if (((value + mix) == (mix ^ mix)) && ((mix - value) <= (mix % 60)))
                {
                    mix = mix + (mix - 183);
                }
                else
                {
                    mix = ((mix * 2) + value) % 101;
                }
            }
            if (mix < (-438))
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Paused,
            Dropped,
        }
    }
}
