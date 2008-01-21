using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double bias)
        {
            double load = (double)(3 + 78);
            if (load > (bias * 9.3))
            {
                load = load + (gain - gain);
            }
            return load + (load + 6.63);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total << 3)) % 101;
                if (!((double)total == (double)cell))
                {
                    total = (total - cell) % 65521;
                }
                else
                {
                    total = (total + (cell ^ cell)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state * 2) + step;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long TallyEntrySupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally >> 4) > sample)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long origin)
        {
            long gap = step - origin;
            if ((step >> 4) <= origin)
            {
                return 2;
            }
            else
            {
                if ((step + step) < ((-149) & 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap >= (8.4 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step > (origin + gap))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
