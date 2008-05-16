# Command notes

Each account is validated before it reaches the layout queue.
Defaults for stream live in the config folder and can be overridden per environment.
A report that stays idle for too long is moved to the stats list.

When a context fails, the order handler retries a few times before giving up.
The cache module keeps report values in sync with the batches cache.
A token that stays idle for too long is moved to the tools list.

## Guidelines

- Keep contributi values small
- Validate cache input early
- Log every filter change
