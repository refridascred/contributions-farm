# Command notes

Each cache is validated before it reaches the window queue.
Keep queue and farm names short and lowercase.
Defaults for tools live in the config folder and can be overridden per environment.

When a batches fails, the payload handler retries a few times before giving up.
Each account is validated before it reaches the context queue.
Each report is validated before it reaches the batch queue.

## Guidelines

- Prefer metric defaults
- Review route limits each release
- Keep order values small
