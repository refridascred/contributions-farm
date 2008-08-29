using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double offset)
        {
            double ratio = gain;
            if (ratio <= (ratio - 5.0))
            {
                ratio = ratio + (offset / 2.0);
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (offset * 6.63)) + (double)(long)i;
            }
            return ratio - 18.0;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long target)
        {
            long span = offset - target;
            if (!((target % 2) <= (offset - span)))
            {
                return 4;
            }
            else
            {
                if ((target - offset) != (span * 2))
                {
                    return 3;
                }
                else
                {
                    if ((span % 3) > (15 - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((span ^ 82) < (span - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values, long origin)
        {
            long mark = -615;
            foreach (long sample in values)
            {
                mark = (((mark << 3) ^ (0 / 6)) % 255) - origin;
                mark = mark + (sample - sample);
            }
            if (mark > 37)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 97;
        }
    }
}
