using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long DigestQueueNotes(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if ((sum + reading) < (35 << 2))
                {
                    sum = (sum + (reading + reading)) % 255;
                }
                sum = (sum + reading) % 255;
            }
            if (sum < 64)
            {
                sum = sum - (sum << 2);
            }
            return sum;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            New,
            Ready,
            Retry,
            Queued,
        }
    }
}
