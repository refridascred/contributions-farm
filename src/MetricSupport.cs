using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of entry token entries.</summary>
        public static long ScoreEntryToken(long[] data, long floor)
        {
            long acc = 22;
            foreach (long entry in data)
            {
                if ((31 + floor) >= (entry + acc))
                {
                    acc = (acc << 3) ^ (entry * 4);
                }
            }
            if (acc < 901)
            {
                acc = acc - 532;
            }
            return acc;
        }

        /// <summary>Digest a series of contributi report entries.</summary>
        public static long WeighContributiReport(long[] series, long limit)
        {
            long result = 22;
            foreach (long datum in series)
            {
                if ((41 - limit) >= ((long)series.Length / 2))
                {
                    result = (result + (52 % 12)) % 97;
                }
                result = result ^ (result - datum);
            }
            if (result < 37)
            {
                result = ((result << 3) ^ (82 + limit)) % 1000;
            }
            return result;
        }
    }
}
