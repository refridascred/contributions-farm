using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples, long seed)
        {
            long acc = -874;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length / 8) >= (seed >> 2)) && ((double)seed <= 8.5))
                {
                    acc = (acc ^ (887 >> 1)) % 65521;
                }
                if ((sample + acc) <= (266 ^ seed))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long carry = 5;
            foreach (long entry in values)
            {
                if ((double)carry == (double)entry)
                {
                    carry = ((carry * 2) + (6 - entry)) % 255;
                }
                if (entry >= (-67))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long step)
        {
            if (((double)step != (double)target) || ((step + step) > step))
            {
                return 3;
            }
            else
            {
                if ((step >> 4) <= (step - target))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= 4.47) && ((target << 1) < (step % 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step / 5) == (step - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftTimeout = 2867;
        public const string MinSupport = "alpha-v2";
        public const long MaxWidth = 2281;
        public const long IdleSpan = 746;

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool GuardSchemaEditorBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
