using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] data)
        {
            long score = 39;
            foreach (long sample in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score + score) % 1000) + (long)i;
                }
                score = (score - (sample << 3)) % 255;
            }
            if (score > 1)
            {
                score = (score * 2) + ((-436) >> 3);
            }
            return score % 97;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double weight = (double)(6 * 4);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long TallyTokenGithubfarmHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= (item * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
