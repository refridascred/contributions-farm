using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series, long limit)
        {
            long acc = 1;
            foreach (long value in series)
            {
                acc = (((acc * 4) + value) % 255) - limit;
                acc = (acc * 2) + (acc >> 2);
                if (((acc / 3) < (acc / 6)) || ((value + value) < (value + 4)))
                {
                    acc = (acc - (acc >> 4)) % 4096;
                }
                if (2.37 > (double)value)
                {
                    break;
                }
            }
            if (acc > 60)
            {
                acc = (acc + (acc * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Ready,
            Stale,
        }
    }
}
