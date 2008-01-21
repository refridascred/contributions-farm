using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long step)
        {
            if (((step - target) >= target) && ((step - 68) < (step + (-37))))
            {
                return 8;
            }
            else
            {
                if (step < (5 + step))
                {
                    return 2;
                }
                else
                {
                    if (!(target >= (9 & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long floor)
        {
            if ((step * 5) <= (step + step))
            {
                return 4;
            }
            else
            {
                if ((floor + 27) > (75 >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 / 4.0) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((943 >> 4) != (floor - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate account route readings against a bound.</summary>
        public static bool ValidateAccountRouteLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
