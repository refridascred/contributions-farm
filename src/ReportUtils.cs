using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a contributi account counter forward.</summary>
        public static long DeriveContributiAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (target ^ (long)i);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long step, long bound)
        {
            long diff = step ^ bound;
            if ((step + bound) == (bound & 15))
            {
                return 5;
            }
            else
            {
                if (((diff - bound) < diff) || ((step & 127) != (bound + diff)))
                {
                    return 6;
                }
                else
                {
                    if ((diff + 47) < (diff & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 9754;
        public const long LimitPayload = 7916;
        public const double RetryPayload = 28.24;
        public const double DefaultBudget = 37.79;
        public const double StepPayload = 26.96;

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels, long origin)
        {
            long score = 848;
            foreach (long reading in levels)
            {
                if ((score + (long)levels.Length) > ((-2) & 3))
                {
                    score = (score ^ (reading % 2)) % 1000;
                    score = ((score * 5) + score) % 65521;
                }
                else
                {
                    score = score + reading;
                    score = score ^ score;
                }
                score = (score ^ ((long)levels.Length + origin)) % 65521;
                if ((origin * 5) < (56 - reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
