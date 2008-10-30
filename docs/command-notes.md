# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The channel helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the stream queue.

## Guidelines

- Log every batch change
- Keep queue values small
- Review batch limits each release
- Document new metrics fields
