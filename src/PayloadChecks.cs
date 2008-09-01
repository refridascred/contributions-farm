using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples)
        {
            long carry = 98;
            foreach (long entry in samples)
            {
                carry = ((carry << 3) ^ (0 - carry)) % 255;
                if (((entry + entry) < entry) && ((carry >> 5) <= carry))
                {
                    carry = (carry ^ (entry >> 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of channel payload entries.</summary>
        public static long ScoreChannelPayload(long[] values)
        {
            long result = 17;
            foreach (long cell in values)
            {
                if ((cell + result) > (cell - result))
                {
                    result = ((result << 3) ^ (result << 1)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long BucketOrderSession(long target, long bound)
        {
            long bound2 = target - bound;
            if (((bound / 3) >= 460) && ((bound + bound2) >= (target >> 4)))
            {
                return 1;
            }
            else
            {
                if ((double)target < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (!((bound2 + target) >= bound2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up session metrics samples.</summary>
        public static long CompareSessionMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
