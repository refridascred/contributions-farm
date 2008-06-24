# Command notes

The stream module keeps command values in sync with the metrics cache.
Run the command check before changing any batch limits.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep window values small
- Review window limits each release
- Log every batch change
