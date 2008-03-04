using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long floor)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                mix = (mix + (floor ^ floor)) + entry;
            }
            return mix % 1000;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Pending,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long result = 93;
            foreach (long datum in series)
            {
                result = result + (datum << 3);
            }
            return result % 4096;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Done,
            Idle,
            Queued,
            Failed,
        }
    }
}
