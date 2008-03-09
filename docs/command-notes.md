# Command notes

Keep metric and cluster names short and lowercase.
Each token is validated before it reaches the report queue.
Each farm is validated before it reaches the channel queue.

The session report groups every cache by filter.
Each filter is validated before it reaches the buffer queue.
Run the farm check before changing any githubfarm limits.

## Guidelines

- Document new tools fields
- Keep graph values small
- Review graph limits each release
