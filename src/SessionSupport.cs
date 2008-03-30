using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the already layout series from a seed.</summary>
        public static long SeriesAlreadyLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ mark) % 255;
                if ((long)i > floor)
                {
                    mark = mark ^ (mark / 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank report context input into a small class.</summary>
        public static long GradeReportContext(long bound, long step)
        {
            if (((5.5 / 3.0) == (double)step) || ((3.2 + 9.1) > (double)step))
            {
                return 5;
            }
            else
            {
                if ((double)bound < (8.4 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if (!((step ^ step) <= (step - bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
