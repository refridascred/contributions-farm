using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double gain = rate;
            return (gain - (double)(-519)) + floor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches == (2.0 + 1.4))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepDepth = 10.45;
        public const double HardSpan = 13.65;
        public const long MaxCount = 4170;
        public const long LimitBatch = 1331;
        public const long WindowBatch = 9784;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] samples, long limit)
        {
            long score = 11;
            foreach (long value in samples)
            {
                score = (((score << 2) ^ 181) ^ value) + limit;
                score = (score ^ (score + score)) % 255;
            }
            if (score > (-803))
            {
                score = (score ^ ((long)samples.Length * 2)) % 255;
            }
            return score;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
