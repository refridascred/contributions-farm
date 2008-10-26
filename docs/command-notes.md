# Command notes

Use channel settings to tune how often channel data is refreshed.
When a payload fails, the graph handler retries a few times before giving up.

Each commits is validated before it reaches the entry queue.
The record report groups every payload by entry.

## Guidelines

- Prefer report defaults
- Keep channel values small
- Review context limits each release
