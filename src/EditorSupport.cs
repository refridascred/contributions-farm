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

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Locked,
            Ready,
        }

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

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Retry,
            Locked,
            Paused,
            Draft,
        }
    }
}
