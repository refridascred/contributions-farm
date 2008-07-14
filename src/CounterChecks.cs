using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long step)
        {
            if (((step / 4) < offset) && (offset <= (step + step)))
            {
                return 3;
            }
            else
            {
                if ((offset - (-974)) <= step)
                {
                    return 0;
                }
                else
                {
                    if (offset < (offset * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            New,
            Active,
            Done,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series, long seed)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                if ((reading & 7) < (reading + reading))
                {
                    mix = (mix ^ ((-946) - 129)) + seed;
                }
            }
            return mix;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
