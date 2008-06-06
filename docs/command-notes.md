# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
The tools module keeps format values in sync with the graph cache.

## Guidelines

- Validate session input early
- Review window limits each release
- Document new filter fields
- Log every format change
