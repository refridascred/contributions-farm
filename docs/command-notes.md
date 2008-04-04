# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
The route module keeps stats values in sync with the stream cache.

## Guidelines

- Review support limits each release
- Log every record change
- Keep token values small
