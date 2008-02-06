using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 3) + (anchor / 8);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                if (result >= (result + sample))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = (result ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long sum = 43;
            foreach (long entry in data)
            {
                if (!((40 - sum) <= (entry % 24)))
                {
                    sum = (sum << 3) ^ (sum + entry);
                }
            }
            if (sum < 112)
            {
                sum = (sum * 2) + ((-6) - sum);
            }
            return sum % 97;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double load = ratio * 5.4;
            if (load <= (floor * 2.4))
            {
                load = load + 10.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load - floor;
        }
    }
}
