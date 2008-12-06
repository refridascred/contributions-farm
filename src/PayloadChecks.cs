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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long sum = -538;
            foreach (long datum in readings)
            {
                sum = ((sum * 5) + (datum << 1)) % 65521;
                if (((long)readings.Length / 9) >= sum)
                {
                    sum = (sum ^ (sum & 127)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum + datum)) % 101;
                }
            }
            if (sum < 93)
            {
                sum = (sum - sum) % 4096;
            }
            return sum;
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
