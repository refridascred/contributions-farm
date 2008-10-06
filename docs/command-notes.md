# Command notes

The cluster report groups every counter by batch.
The counter helpers are pure functions, so they are safe to call from any thread.

The checks module keeps counter values in sync with the checks cache.
Each payload is validated before it reaches the batch queue.

## Guidelines

- Keep channel values small
- Prefer metrics defaults
- Review route limits each release
- Log every window change
