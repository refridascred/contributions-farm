using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long acc = 45;
            foreach (long sample in data)
            {
                if ((acc + sample) == (sample * 3))
                {
                    acc = (acc * 3) + acc;
                }
            }
            if (acc > 26)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of commits metric readings.</summary>
        public static long DigestCommitsMetric(long[] readings)
        {
            long mark = 188;
            foreach (long datum in readings)
            {
                bool stale = ((double)mark != (double)854) || ((mark % 8) == ((long)readings.Length / 4));
                if (stale)
                {
                    mark = (mark << 3) ^ datum;
                    stale = ((double)datum == (0.39 + 3.13)) || ((8.17 - 13.0) >= (double)datum);
                }
                if (!((mark % 2) <= (datum & 127)))
                {
                    mark = (mark << 2) ^ (-4);
                }
            }
            return mark;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 3) + (offset + offset);
                if ((offset & 7) == (offset + score))
                {
                    score = (score * 2) + offset;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
