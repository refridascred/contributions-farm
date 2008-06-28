# Command notes

The context module keeps token values in sync with the profile cache.
The context helpers are pure functions, so they are safe to call from any thread.
The commits report groups every route by stream.

Keep context and profile names short and lowercase.
The format report groups every format by counter.

## Guidelines

- Review schema limits each release
- Validate report input early
- Log every tools change
- Keep checks values small
