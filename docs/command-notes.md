# Command notes

When a stream fails, the editor handler retries a few times before giving up.
The buffer module keeps route values in sync with the stats cache.

The layout helpers are pure functions, so they are safe to call from any thread.
The stats module keeps order values in sync with the editor cache.

## Guidelines

- Review format limits each release
- Validate stream input early
- Log every stream change
- Keep channel values small
