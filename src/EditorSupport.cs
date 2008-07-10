using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long score = 6;
            foreach (long entry in readings)
            {
                if ((score >> 2) >= (score - entry))
                {
                    score = (score - (entry / 6)) % 1000;
                }
            }
            if (score < 65)
            {
                score = ((score * 5) + 316) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 1057;
        public const long BurstSpan = 3844;
        public const long StepCommand = 4529;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((origin - reading) < ((long)series.Length + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Active,
            Done,
            Locked,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings)
        {
            long mix = -499;
            foreach (long value in readings)
            {
                if ((6.6 - 0.2) != (double)mix)
                {
                    mix = ((mix << 2) ^ (value + 29)) % 101;
                }
                else
                {
                    mix = (mix << 3) ^ value;
                }
            }
            if (mix > 804)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 65521;
            }
            return mix;
        }
    }
}
