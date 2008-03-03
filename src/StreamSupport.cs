using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Locked,
            Closed,
        }

        /// <summary>Adjust a already counter reading.</summary>
        public static double AdjustAlreadyCounter(double bias, double span)
        {
            double load = bias;
            if (load > 1.06)
            {
                load = load - load;
            }
            else
            {
                load = load + (span / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)0;
        }
    }
}
