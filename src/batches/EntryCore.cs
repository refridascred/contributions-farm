using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph format samples are out of range.</summary>
        public static long MeasureGraphFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!(cell < (seen / 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long total = 939;
            foreach (long cell in series)
            {
                total = (total - (total * 5)) + cell;
            }
            if (total > 406)
            {
                total = (total - total) % 97;
            }
            return total % 65521;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((floor << 2) <= (seen - (long)readings.Length))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
