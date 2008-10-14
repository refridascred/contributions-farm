# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
A layout that stays idle for too long is moved to the metrics list.
Run the format check before changing any farm limits.

Each metric is validated before it reaches the batch queue.
The layout module keeps context values in sync with the batches cache.
When a channel fails, the order handler retries a few times before giving up.

## Guidelines

- Review account limits each release
- Log every support change
- Validate metrics input early
- Prefer filter defaults
