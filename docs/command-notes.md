# Command notes

A cluster that stays idle for too long is moved to the already list.
The context report groups every stats by record.

The cluster helpers are pure functions, so they are safe to call from any thread.
Keep cluster and filter names short and lowercase.
Each batches is validated before it reaches the metrics queue.

## Guidelines

- Keep schema values small
- Document new metric fields
- Review profile limits each release
- Prefer session defaults
