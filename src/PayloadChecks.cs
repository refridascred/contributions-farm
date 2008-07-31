using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset - 8) <= (86 / 7))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (7.3 + 5.2))
                {
                    return 8;
                }
                else
                {
                    if (((gap - 748) <= limit) && (limit <= gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap != (7.0 + 7.93))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (long)i) % 101;
                if ((86 + limit) < (state % 2))
                {
                    state = state + (long)i;
                    break;
                }
                else
                {
                    state = (state ^ (state * 2)) % 97;
                    state = (state + (state << 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
