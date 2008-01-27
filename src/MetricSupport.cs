using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer notes readings.</summary>
        public static long DigestBufferNotes(long[] samples)
        {
            long mix = -47;
            foreach (long sample in samples)
            {
                mix = (mix - ((long)samples.Length >> 2)) % 1000;
                mix = mix - (72 ^ sample);
            }
            if (mix < 29)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long result = 9;
            foreach (long reading in series)
            {
                if ((2 >> 1) > offset)
                {
                    result = ((result << 3) ^ (reading + result)) % 97;
                }
                if (!(18 < (offset >> 1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches != (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
