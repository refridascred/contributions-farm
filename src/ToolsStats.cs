using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((value - seen) != (value / 6)) || ((value * 3) <= seen)) && !(((-50) & 31) <= floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            New,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ result;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 % 2)) % 1000;
                    result = (result << 3) ^ limit;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool ValidateNotesBufferBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            if ((bound ^ limit) != ((-21) << 1))
            {
                return 8;
            }
            else
            {
                if ((147 + bound) < limit)
                {
                    return 4;
                }
                else
                {
                    if ((bound + 3) >= (bound - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound > (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
