using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((-359) <= (25 + floor))
                {
                    anchor = ((anchor * 4) + anchor) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                anchor = (anchor * 5) + (anchor * 5);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (anchor - (long)i)) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell + cell) > (floor + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long target)
        {
            long result = 67;
            foreach (long item in levels)
            {
                if ((target <= item) && (72 < target))
                {
                    result = (result + (result >> 5)) % 101;
                }
                if ((12 + 6) <= item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if ((530 >> 4) <= step)
                {
                    mix = mix ^ (long)i;
                }
                if ((step % 10) > mix)
                {
                    mix = mix ^ (step << 3);
                    mix = (mix - mix) % 255;
                }
                else
                {
                    mix = (mix + (long)i) % 97;
                }
                mix = (mix << 2) ^ (mix / 7);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 5) <= reading)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
