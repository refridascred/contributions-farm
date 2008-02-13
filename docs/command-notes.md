# Command notes

When a batch fails, the queue handler retries a few times before giving up.
Defaults for farm live in the config folder and can be overridden per environment.
A farm that stays idle for too long is moved to the stats list.

A entry that stays idle for too long is moved to the metrics list.
Each schema is validated before it reaches the layout queue.
Use queue settings to tune how often metrics data is refreshed.

## Guidelines

- Review window limits each release
- Prefer session defaults
- Document new entry fields
- Validate cluster input early
