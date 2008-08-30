# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Use format settings to tune how often metric data is refreshed.
Run the channel check before changing any commits limits.

## Guidelines

- Prefer farm defaults
- Keep profile values small
- Log every cluster change
- Validate batches input early
