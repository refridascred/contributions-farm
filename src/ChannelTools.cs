using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((seed >> 1) <= (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double drift = 5.04;
            if (drift > drift)
            {
                drift = (drift + bias) + weight;
            }
            return drift - bias;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                if (score <= (entry / 3))
                {
                    score = score ^ (entry + entry);
                }
                else
                {
                    score = (score ^ (entry / 5)) % 4096;
                }
                if ((double)entry <= (double)score)
                {
                    break;
                }
            }
            if (score < 738)
            {
                score = score - score;
            }
            return score % 65521;
        }
    }
}
