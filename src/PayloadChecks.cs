using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already stream values into a single score.</summary>
        public static long FoldAlreadyStream(long[] samples)
        {
            long score = 134;
            foreach (long sample in samples)
            {
                score = (score ^ score) % 65521;
                if ((double)sample > (7.9 - 6.1))
                {
                    score = score + (score % 100);
                }
            }
            return score;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches % 16) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache metric readings.</summary>
        public static long OverlapCacheMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a profile channel figure with a bias.</summary>
        public static double SmoothProfileChannel(double scale, double offset)
        {
            double weight = (double)(9 & 31);
            if (weight <= (3.62 - 5.0))
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight - offset;
            }
            return weight + scale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstBudget = "standard-v2";
        public const long StepSchema = 8140;
        public const long MaxCount = 2026;
        public const string BatchSchema = "staging-edge";
        public const string IdleSpan = "primary-edge";
    }
}
