# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Each payload is validated before it reaches the order queue.

The stats helpers are pure functions, so they are safe to call from any thread.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review already limits each release
- Keep report values small
- Document new editor fields
- Prefer token defaults
