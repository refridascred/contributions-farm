# Command notes

The stats module keeps record values in sync with the command cache.
Run the tools check before changing any token limits.

When a filter fails, the context handler retries a few times before giving up.
The filter module keeps buffer values in sync with the route cache.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep account values small
- Document new farm fields
- Log every cache change
