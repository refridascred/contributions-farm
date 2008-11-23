# Command notes

Each batches is validated before it reaches the graph queue.
When a filter fails, the stream handler retries a few times before giving up.
Run the cluster check before changing any stats limits.

## Guidelines

- Review batch limits each release
- Document new session fields
- Keep cache values small
- Prefer entry defaults
