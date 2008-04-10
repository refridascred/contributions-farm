# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Each counter is validated before it reaches the batches queue.
Each buffer is validated before it reaches the tools queue.

## Guidelines

- Prefer metric defaults
- Review queue limits each release
- Document new schema fields
- Keep already values small
