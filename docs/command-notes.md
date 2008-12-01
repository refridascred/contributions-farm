# Command notes

Each batch is validated before it reaches the commits queue.
Keep counter and metric names short and lowercase.

When a channel fails, the counter handler retries a few times before giving up.
Keep editor and graph names short and lowercase.

## Guidelines

- Review queue limits each release
- Prefer already defaults
- Validate filter input early
- Log every metric change
