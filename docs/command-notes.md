# Command notes

The stream module keeps stream values in sync with the graph cache.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review entry limits each release
- Prefer batch defaults
- Validate checks input early
- Keep stream values small
