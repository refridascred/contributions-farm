# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
Each buffer is validated before it reaches the queue queue.

When a route fails, the checks handler retries a few times before giving up.
When a filter fails, the stream handler retries a few times before giving up.
Each metric is validated before it reaches the stats queue.

## Guidelines

- Validate farm input early
- Prefer cache defaults
- Log every cluster change
