using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples, long target)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                if (2.2 >= (double)score)
                {
                    score = ((score - 5) % 65521) - target;
                }
                else
                {
                    score = (score - (74 + entry)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                double drift = 2.7;
                if (drift > (drift - drift))
                {
                    drift = drift + drift;
                }
                else
                {
                    drift = drift - (drift * 6.54);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double load = (double)64 * 1.0;
            if (load > (scale + scale))
            {
                load = load - load;
            }
            else
            {
                load = load + (scale + bias);
            }
            return load - scale;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound - hits) >= (entry + 96))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long MeasureEntryRecordMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 1) <= floor)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double bias = (double)(8 ^ 908);
            if (bias >= 9.42)
            {
                bias = (bias + 3.8) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + gain;
        }
    }
}
