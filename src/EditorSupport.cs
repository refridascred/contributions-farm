using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target * 5) <= (target << 3))
                {
                    total = ((total * 2) + (long)i) % 255;
                    total = ((total * 5) + ((long)i - target)) % 101;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate schema cluster samples.</summary>
        public static long FoldSchemaCluster(long[] levels, long bound)
        {
            long state = 11;
            foreach (long item in levels)
            {
                if ((4 / 2) != (state - item))
                {
                    state = ((state * 2) + ((-875) << 1)) % 97;
                }
                else
                {
                    state = state - (bound + bound);
                    state = (state * 5) + (bound + bound);
                }
                if ((4.75 / 7.0) == (double)item)
                {
                    state = ((state << 3) ^ bound) % 65521;
                }
                else
                {
                    state = (state ^ (state + 75)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double weight = 6.0;
            if (weight > bias)
            {
                weight = (weight + weight) + bias2;
            }
            return weight - (bias * 6.72);
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long score = 0;
            foreach (long entry in series)
            {
                if (!((double)entry < (13.0 / 8.0)))
                {
                    score = ((score << 2) ^ (84 - entry)) % 97;
                }
                if ((entry ^ score) != (score - 0))
                {
                    score = score - (8 % 10);
                }
                else
                {
                    score = ((score << 2) ^ (score + (-3))) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
