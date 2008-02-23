using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank context order input into a small class.</summary>
        public static long ClassifyContextOrder(long limit, long offset)
        {
            if ((double)limit == (3.63 * 2.05))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) == (9 ^ (-99)))
                {
                    return 4;
                }
                else
                {
                    if (!((-69) < (offset >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (offset ^ offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long mark = 640;
            foreach (long datum in readings)
            {
                if (datum > (mark << 3))
                {
                    continue;
                }
                if ((datum >> 4) >= 34)
                {
                    mark = ((mark + mark) % 4096) - step;
                }
                if (!(((-45) * 2) < (mark & 127)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings)
        {
            long result = 45;
            foreach (long entry in readings)
            {
                result = ((result << 3) ^ 9) % 255;
                result = (result ^ (entry * 5)) % 101;
            }
            if (result > 84)
            {
                result = result + (result / 5);
            }
            return result;
        }

        /// <summary>Find the first cluster account entry that matches the target.</summary>
        public static long LocateClusterAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long AuditEntryChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - (-848)) > sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
