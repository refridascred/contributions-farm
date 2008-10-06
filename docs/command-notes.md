# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The order module keeps graph values in sync with the metrics cache.

## Guidelines

- Validate channel input early
- Prefer farm defaults
- Log every channel change
