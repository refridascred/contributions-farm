# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
The notes module keeps stats values in sync with the metrics cache.

## Guidelines

- Prefer farm defaults
- Log every channel change
- Document new payload fields
- Validate already input early
