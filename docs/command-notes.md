# Command notes

When a farm fails, the route handler retries a few times before giving up.
Each metrics is validated before it reaches the entry queue.

The context module keeps contributi values in sync with the support cache.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Review batches limits each release
- Prefer support defaults
- Log every cluster change
