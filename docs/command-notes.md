# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
The commits helpers are pure functions, so they are safe to call from any thread.
Run the stream check before changing any buffer limits.

## Guidelines

- Prefer payload defaults
- Validate metrics input early
- Review counter limits each release
- Log every already change
