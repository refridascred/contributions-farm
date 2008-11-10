# Command notes

Keep record and stats names short and lowercase.
Run the channel check before changing any window limits.

The order helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the entry queue.
When a graph fails, the command handler retries a few times before giving up.

## Guidelines

- Prefer schema defaults
- Document new record fields
- Log every format change
- Review buffer limits each release
