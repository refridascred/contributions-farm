# Command notes

The notes module keeps layout values in sync with the stream cache.
Each payload is validated before it reaches the entry queue.

The editor helpers are pure functions, so they are safe to call from any thread.
The format module keeps graph values in sync with the payload cache.

## Guidelines

- Log every cache change
- Keep session values small
- Document new already fields
