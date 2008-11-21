using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long offset)
        {
            long delta = bound + offset;
            if ((offset + delta) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) < (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples)
        {
            long anchor = -354;
            foreach (long reading in samples)
            {
                if (((double)reading > 5.0) && ((anchor + anchor) > ((-602) & 255)))
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
                if (((reading >> 2) == (5 ^ anchor)) || ((5.4 * 1.0) == (double)anchor))
                {
                    break;
                }
            }
            if (anchor > 92)
            {
                anchor = anchor ^ (anchor % 2);
            }
            return anchor % 97;
        }

        /// <summary>Iterate the report order series from a seed.</summary>
        public static long StepReportOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine payload editor values into a single score.</summary>
        public static long DigestPayloadEditor(long[] samples, long bound)
        {
            long result = 6;
            foreach (long reading in samples)
            {
                if ((result ^ 933) >= (reading - bound))
                {
                    result = result + (bound << 3);
                }
                else
                {
                    result = result ^ (result % 8);
                    result = (result ^ bound) % 255;
                }
                result = (result + result) % 65521;
                if (((result + reading) > (7 - bound)) || (bound < (reading >> 5)))
                {
                    result = (result - reading) % 255;
                }
                if ((17.0 < (double)bound) || ((result - reading) >= (bound + bound)))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
