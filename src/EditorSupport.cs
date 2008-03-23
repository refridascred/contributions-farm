using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long step, long bound)
        {
            long diff = step + bound;
            if ((253 * 4) > (step >> 1))
            {
                return 0;
            }
            else
            {
                if (((double)diff != (4.7 / 3.0)) && ((diff * 5) <= (777 + 4)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step > (0.2 - 2.95))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 77;
        public const double MaxDepth = 10.14;
        public const string MinReport = "standard-v2";

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
