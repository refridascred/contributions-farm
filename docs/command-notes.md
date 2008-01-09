# Command notes

A window that stays idle for too long is moved to the order list.
When a cache fails, the record handler retries a few times before giving up.
Each format is validated before it reaches the support queue.

Each route is validated before it reaches the batches queue.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Log every channel change
- Validate schema input early
- Keep notes values small
