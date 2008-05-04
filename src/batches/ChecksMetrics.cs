using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Queued,
            New,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((reading * 2) <= tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double weight = 5.5;
            return (weight - scale) + span;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 - 0.46) > (double)(long)i)
                {
                    anchor = (anchor * 3) + anchor;
                }
                anchor = (anchor + ((long)i - anchor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double floor)
        {
            double rate = (double)(156 * 4);
            return (rate - (scale * 4.87)) + floor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long result = -23;
            foreach (long cell in values)
            {
                if ((cell * 3) <= (result * 5))
                {
                    result = (result ^ cell) % 97;
                }
                else
                {
                    result = ((result * 3) + (result & 31)) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
