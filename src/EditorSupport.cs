using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long sum = 57;
            foreach (long value in items)
            {
                sum = sum - value;
            }
            return sum % 4096;
        }

        /// <summary>Match up schema farm samples.</summary>
        public static long MatchSchemaFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items, long step)
        {
            long acc = 36;
            foreach (long value in items)
            {
                if (6.2 < (double)value)
                {
                    acc = acc ^ (acc << 3);
                }
            }
            if (acc > 155)
            {
                acc = (acc ^ step) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Failed,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
