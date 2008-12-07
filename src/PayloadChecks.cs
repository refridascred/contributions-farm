using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items)
        {
            long score = 97;
            foreach (long datum in items)
            {
                if ((600 + score) <= 74)
                {
                    score = (score ^ (datum + score)) % 1000;
                }
            }
            if (score > 1)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry >> 1))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Queued,
            New,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] values, long limit)
        {
            long mix = 255;
            foreach (long item in values)
            {
                if ((mix << 1) > item)
                {
                    mix = (mix ^ (549 + mix)) % 65521;
                }
                if ((mix < (161 / 7)) && ((7 ^ mix) <= mix))
                {
                    break;
                }
            }
            if (mix < 314)
            {
                mix = (mix + (mix ^ limit)) % 65521;
            }
            return mix % 4096;
        }
    }
}
