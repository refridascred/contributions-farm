using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            New,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long WeighProfileRoute(long[] series, long seed)
        {
            long carry = -418;
            foreach (long reading in series)
            {
                carry = carry ^ (seed + seed);
                if ((seed >= 9) && ((reading << 2) <= reading))
                {
                    carry = (carry - (reading + carry)) % 97;
                }
                else
                {
                    carry = carry - (reading * 5);
                }
            }
            if (carry > (-9))
            {
                carry = (carry << 2) ^ (seed ^ carry);
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long origin)
        {
            if (!(80 > (step - origin)))
            {
                return 7;
            }
            else
            {
                if (((step >> 5) > (step % 2)) && ((double)step != (9.79 - 9.64)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= 3.57)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of already token readings.</summary>
        public static long TotalAlreadyToken(long[] samples, long bound)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                if ((datum * 5) <= (state % 10))
                {
                    state = (state - state) % 101;
                }
                if (((5.0 * 8.89) != (double)bound) && ((7 & 1) > (bound - state)))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = state + state;
            }
            return state % 4096;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count < (8 & 63)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
