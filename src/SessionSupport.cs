using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 25;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ (945 + entry)) ^ (long)i;
                }
                if (!(entry < (407 + 2)))
                {
                    continue;
                }
                if ((entry << 3) > (entry & 255))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double load = rate * 7.0;
            if (load <= (rate / 7.0))
            {
                load = (load + (rate + load)) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (double)7;
        }
    }
}
