using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double rate = (ratio * 10.0) / 7.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + (rate - ratio);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the record format series from a seed.</summary>
        public static long IterateRecordFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = score + floor;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
