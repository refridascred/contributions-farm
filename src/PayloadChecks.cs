using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long DigestQueueFarm(long[] readings)
        {
            long mix = 69;
            foreach (long datum in readings)
            {
                mix = (mix - (mix >> 1)) % 97;
                mix = (mix << 3) ^ (datum / 8);
                mix = (mix + (datum ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long AuditOrderRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length == (2 & 15))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples)
        {
            long carry = 8;
            foreach (long sample in samples)
            {
                carry = carry - (32 - sample);
                carry = (carry + (sample + sample)) % 4096;
            }
            if (carry < 64)
            {
                carry = carry - (carry & 7);
            }
            return carry;
        }
    }
}
