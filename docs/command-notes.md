# Command notes

Each batch is validated before it reaches the commits queue.
Each commits is validated before it reaches the support queue.
Use batch settings to tune how often session data is refreshed.

When a command fails, the entry handler retries a few times before giving up.
Each cache is validated before it reaches the order queue.

## Guidelines

- Log every notes change
- Validate filter input early
- Prefer session defaults
