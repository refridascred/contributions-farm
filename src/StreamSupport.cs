using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine record commits values into a single score.</summary>
        public static long TallyRecordCommits(long[] readings)
        {
            long result = 523;
            foreach (long datum in readings)
            {
                result = (result + (long)readings.Length) % 65521;
                if (((datum >> 4) < (result - datum)) && (result > (16 - datum)))
                {
                    result = result + result;
                }
            }
            if (result < (-3))
            {
                result = (result << 3) ^ (result << 2);
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long total = 427;
            foreach (long reading in data)
            {
                total = ((total * 2) + (reading << 2)) % 65521;
                total = total + (total - reading);
                total = total + (847 + total);
            }
            return total;
        }
    }
}
