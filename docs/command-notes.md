# Command notes

The batches module keeps stream values in sync with the window cache.
A metrics that stays idle for too long is moved to the batches list.

The order module keeps token values in sync with the farm cache.
Run the queue check before changing any order limits.
When a stats fails, the farm handler retries a few times before giving up.

## Guidelines

- Validate queue input early
- Prefer session defaults
- Keep githubfarm values small
