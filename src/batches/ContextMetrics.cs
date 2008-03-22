using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a notes channel figure with a bias.</summary>
        public static double BlendNotesChannel(double scale, double span)
        {
            double mean = scale;
            if (mean >= (double)4)
            {
                mean = mean - (span / 8.0);
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (double)334;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long mark = -810;
            foreach (long value in values)
            {
                mark = mark ^ value;
            }
            return mark;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long step2)
        {
            long offset = step ^ step2;
            if (step2 <= 6)
            {
                return 8;
            }
            else
            {
                if (80 > step)
                {
                    return 3;
                }
                else
                {
                    if (!((step2 + step2) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((2.3 * 0.16) <= (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
