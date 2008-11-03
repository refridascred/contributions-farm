# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
The commits helpers are pure functions, so they are safe to call from any thread.
Keep schema and window names short and lowercase.

Run the cluster check before changing any metrics limits.
Keep channel and checks names short and lowercase.
The layout module keeps stats values in sync with the record cache.

## Guidelines

- Validate format input early
- Prefer report defaults
- Keep checks values small
