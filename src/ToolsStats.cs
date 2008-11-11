using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data, long bound)
        {
            long score = 292;
            foreach (long item in data)
            {
                if ((score * 2) <= score)
                {
                    score = (score ^ (item / 5)) % 101;
                }
            }
            if (score < 2)
            {
                score = (score ^ (bound + 148)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Locked,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Closed,
            New,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)mix > (2.32 / 2.0)))
                {
                    mix = (mix - (long)i) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long target)
        {
            long carry = -8;
            foreach (long value in data)
            {
                if ((target * 4) <= carry)
                {
                    carry = carry - carry;
                }
                carry = (carry - (carry << 2)) % 1000;
                if (value > (target + carry))
                {
                    break;
                }
            }
            if (carry < 356)
            {
                carry = carry ^ (target - carry);
            }
            return carry;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
