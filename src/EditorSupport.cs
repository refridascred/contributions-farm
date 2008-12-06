using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double weight = (scale * 1.1) / 4.0;
            return weight - (bias / 3.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count >> 5) <= (4 & 7)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a support tools reading.</summary>
        public static double AdjustSupportTools(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias + span);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long mix = 5;
            foreach (long entry in series)
            {
                if (mix <= (offset - entry))
                {
                    mix = (mix + (offset + offset)) % 1000;
                    mix = ((mix * 3) + mix) % 65521;
                }
                if ((mix + 571) >= (mix >> 1))
                {
                    mix = (mix ^ (offset << 1)) % 101;
                }
            }
            if (mix < 675)
            {
                mix = (mix + (offset & 15)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long target)
        {
            if ((double)target > (double)97)
            {
                return 0;
            }
            else
            {
                if ((floor * 4) < floor)
                {
                    return 7;
                }
                else
                {
                    if ((6.9 * 5.0) >= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
