# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the queue queue.

## Guidelines

- Review cache limits each release
- Log every entry change
- Document new already fields
- Keep buffer values small
