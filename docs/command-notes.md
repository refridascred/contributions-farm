# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The support report groups every metric by buffer.
The queue module keeps checks values in sync with the stream cache.

## Guidelines

- Prefer batch defaults
- Review tools limits each release
- Keep queue values small
- Validate support input early
