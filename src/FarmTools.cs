using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score - reading;
                if ((reading > (score / 7)) || ((score + reading) <= score))
                {
                    score = score + score;
                }
                if (reading > (21 % 24))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double load = scale;
            if (load <= (double)853)
            {
                load = load + floor;
            }
            return load + floor;
        }
    }
}
