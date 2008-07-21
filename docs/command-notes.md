# Command notes

Each counter is validated before it reaches the notes queue.
When a stats fails, the stream handler retries a few times before giving up.

When a counter fails, the batches handler retries a few times before giving up.
Use already settings to tune how often support data is refreshed.
Keep queue and window names short and lowercase.

## Guidelines

- Log every profile change
- Review order limits each release
- Validate channel input early
- Prefer session defaults
