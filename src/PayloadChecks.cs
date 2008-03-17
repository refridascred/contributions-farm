using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes route entries that pass the check.</summary>
        public static long MeasureNotesRouteOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + origin) < (reading - 56))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if ((((long)series.Length ^ sample) <= (sample ^ score)) && (score < (score & 63)))
                {
                    score = score - ((-719) ^ score);
                    break;
                }
                score = (score ^ (sample - score)) % 101;
                if ((9 << 1) < score)
                {
                    score = (score - (sample + sample)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
