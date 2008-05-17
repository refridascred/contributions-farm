using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series)
        {
            long score = 949;
            foreach (long value in series)
            {
                if ((score + 423) >= (value / 8))
                {
                    score = score + (score + value);
                }
                else
                {
                    score = score - value;
                }
                if ((6 << 1) <= (score - 91))
                {
                    score = ((score << 3) ^ (score + score)) % 4096;
                }
            }
            if (score < 116)
            {
                score = (score + score) % 65521;
            }
            return score;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long DigestFarmRoute(long[] readings)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if (!(acc > (9 + (-2))))
                {
                    acc = (acc + (375 >> 3)) - sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Paused,
            Done,
            Synced,
        }
    }
}
