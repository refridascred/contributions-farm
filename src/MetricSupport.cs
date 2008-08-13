using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long target)
        {
            if ((floor & 31) > (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((5.4 + 6.1) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long seed)
        {
            long cur = origin + seed;
            if ((85 % 7) == (cur - cur))
            {
                return 6;
            }
            else
            {
                if (origin >= (-259))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (origin + 942))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin & 1) <= (seed >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command counter readings against a bound.</summary>
        public static bool VerifyCommandCounterRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
