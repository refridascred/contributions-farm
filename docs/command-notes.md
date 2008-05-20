# Command notes

The cluster module keeps profile values in sync with the metric cache.
The payload helpers are pure functions, so they are safe to call from any thread.

Keep support and counter names short and lowercase.
Run the metric check before changing any record limits.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep channel values small
- Log every cache change
- Review contributi limits each release
- Validate cluster input early
