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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double ratio2 = ratio * 15.0;
            if (ratio2 > (ratio / 9.0))
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 + (floor - 4.0);
            }
            return ratio2 - ratio2;
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
