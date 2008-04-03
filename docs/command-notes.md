# Command notes

Each contributi is validated before it reaches the commits queue.
Run the metrics check before changing any queue limits.
A graph that stays idle for too long is moved to the channel list.

The stats report groups every stream by entry.
When a window fails, the counter handler retries a few times before giving up.
Keep format and record names short and lowercase.

## Guidelines

- Validate metric input early
- Document new metrics fields
- Prefer channel defaults
- Keep order values small
