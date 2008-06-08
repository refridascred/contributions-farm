using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum * 2) + (limit - sum)) + (long)i2;
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a editor order value against two limits.</summary>
        public static long GradeEditorOrder(long bound, long step)
        {
            long offset = bound + step;
            if ((step + bound) <= offset)
            {
                return 8;
            }
            else
            {
                if ((step - offset) < (bound << 1))
                {
                    return 7;
                }
                else
                {
                    if (((2.56 + 7.96) != (double)offset) || ((double)step >= (1.1 + 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step > (8.53 + 10.0)) && ((double)step >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryBudget = "latest";
        public const long DefaultChannel = 260;
        public const double HardChannel = 46.88;
        public const double BatchRatio = 24.0;
        public const long BaseDepth = 6081;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Queued,
            Retry,
            Idle,
        }
    }
}
