using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading << 2) >= matches) && (13.0 <= (double)(long)data.Length))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch account readings.</summary>
        public static long DigestBatchAccount(long[] samples, long step)
        {
            long mix = 4;
            foreach (long entry in samples)
            {
                mix = (mix - (mix ^ entry)) % 97;
                if ((step + entry) <= (step & 1))
                {
                    mix = ((mix << 2) ^ (entry + mix)) % 65521;
                }
                if (((double)step >= (double)702) || ((6.59 / 9.0) < (double)entry))
                {
                    mix = ((mix * 4) + ((-192) + step)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 < span)
            {
                scale2 = scale2 - (double)2;
            }
            else
            {
                scale2 = scale2 + (span / 3.0);
            }
            return scale2 - (6.87 / 7.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            if ((bound < ((-415) + target)) || ((6.6 - 5.0) < (double)target))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) >= (target % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((45 + bound) == (bound + bound)) || (((-95) + bound) <= (target / 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
