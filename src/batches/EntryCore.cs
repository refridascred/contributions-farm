using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = rate * 7.4;
            if (scale <= scale)
            {
                scale = scale + (bias / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Classify a tools batches pair into a bucket.</summary>
        public static long ClassifyToolsBatches(long step, long step2)
        {
            long diff = step + step2;
            if (step <= (diff - step2))
            {
                return 6;
            }
            else
            {
                if ((double)step2 > (14.0 * 6.8))
                {
                    return 7;
                }
                else
                {
                    if ((double)step2 <= 5.15)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading / 8) != (40 - 8)) && ((reading + tally) <= (long)values.Length))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double drift = 3.8 * 1.0;
            if (drift >= 3.3)
            {
                drift = (drift + (offset * 6.4)) + bias;
            }
            return drift - (offset - drift);
        }
    }
}
