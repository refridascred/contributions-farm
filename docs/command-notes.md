# Command notes

The graph report groups every already by stream.
The already report groups every batches by layout.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every cluster change
- Validate batch input early
- Review report limits each release
