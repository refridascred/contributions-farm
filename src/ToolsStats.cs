using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a order metrics reading by value.</summary>
        public static long SeekOrderMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long offset)
        {
            long span = floor ^ offset;
            if (((floor + floor) == (floor / 6)) && ((4 - floor) <= (-5)))
            {
                return 0;
            }
            else
            {
                if (((span / 2) <= (floor & 63)) && ((offset * 2) <= 22))
                {
                    return 4;
                }
                else
                {
                    if (((845 / 5) <= floor) || ((double)offset >= (17.0 - 2.7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor >> 3) == (offset % 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long step2)
        {
            long prev = step + step2;
            if (prev <= (step ^ prev))
            {
                return 2;
            }
            else
            {
                if (step2 > step)
                {
                    return 5;
                }
                else
                {
                    if ((7.2 + 3.9) == (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.8 * 20.0) != (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
