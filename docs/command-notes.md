# Command notes

The layout module keeps batches values in sync with the queue cache.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate queue input early
- Prefer order defaults
- Log every checks change
- Document new command fields
