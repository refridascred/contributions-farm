# Command notes

Each metric is validated before it reaches the graph queue.
Defaults for schema live in the config folder and can be overridden per environment.
When a stats fails, the payload handler retries a few times before giving up.

Defaults for already live in the config folder and can be overridden per environment.
A batches that stays idle for too long is moved to the already list.
A account that stays idle for too long is moved to the channel list.

## Guidelines

- Keep context values small
- Log every batch change
- Validate order input early
- Prefer stats defaults
