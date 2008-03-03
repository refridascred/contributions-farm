using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1657;
        public const double SoftRatio = 47.97;
        public const long BaseRecord = 857;

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long score = 58;
            foreach (long sample in readings)
            {
                if (((0.58 / 3.0) >= (double)step) && ((sample >> 3) < ((long)readings.Length >> 3)))
                {
                    score = score + step;
                }
            }
            if (score > (-884))
            {
                score = (score << 3) ^ (step % 7);
            }
            return score;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }
    }
}
