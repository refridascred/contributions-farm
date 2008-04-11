using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a queue notes figure with a bias.</summary>
        public static double AdjustQueueNotes(double bias, double bias2)
        {
            double weight = (double)(7 - 53);
            if (weight < (double)51)
            {
                weight = ((weight + (weight + 0.07)) - bias) + bias2;
            }
            return weight - 4.35;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Locked,
            New,
            Draft,
            Pending,
        }
    }
}
