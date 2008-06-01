# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the entry queue.

The already report groups every tools by channel.
The channel module keeps report values in sync with the record cache.
Keep buffer and checks names short and lowercase.

## Guidelines

- Keep notes values small
- Validate session input early
- Log every batches change
- Prefer filter defaults
