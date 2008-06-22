# Command notes

Each token is validated before it reaches the batch queue.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every command change
- Review route limits each release
- Keep stats values small
