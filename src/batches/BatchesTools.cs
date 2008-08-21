using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = (anchor ^ (-70)) % 4096;
                if (((anchor - 6) <= (anchor + cell)) && ((anchor + (-2)) > (-669)))
                {
                    anchor = (anchor ^ (cell / 9)) % 4096;
                }
                if (anchor >= (anchor / 9))
                {
                    break;
                }
            }
            if (anchor < (-58))
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Validate tools githubfarm readings against a bound.</summary>
        public static bool ValidateToolsGithubfarmBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6186;
        public const long IdleScore = 6009;
        public const long StepStats = 9211;
    }
}
