using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Validate editor filter readings against a bound.</summary>
        public static bool GuardEditorFilterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long offset)
        {
            long mix = 78;
            foreach (long cell in values)
            {
                mix = (((mix << 2) ^ (offset + mix)) % 97) + cell;
                if ((double)mix >= 7.1)
                {
                    mix = (mix ^ mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long score = 9;
            foreach (long value in values)
            {
                score = ((score + (value >> 5)) % 97) - target;
            }
            if (score < 17)
            {
                score = score + (score / 4);
            }
            return score % 4096;
        }
    }
}
