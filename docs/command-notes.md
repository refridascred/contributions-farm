# Command notes

The notes module keeps counter values in sync with the window cache.
When a window fails, the format handler retries a few times before giving up.
A stream that stays idle for too long is moved to the metric list.

## Guidelines

- Log every batches change
- Validate window input early
- Keep cluster values small
- Prefer order defaults
