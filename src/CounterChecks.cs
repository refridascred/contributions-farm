using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long offset, long offset2)
        {
            long edge = offset - offset2;
            if (!((offset2 / 6) != (edge - edge)))
            {
                return 5;
            }
            else
            {
                if ((6.9 + 5.85) != (double)offset2)
                {
                    return 0;
                }
                else
                {
                    if (offset >= edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge == (4.0 + 4.89)) && ((44 / 5) < (offset - offset2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
