# Command notes

Each metric is validated before it reaches the farm queue.
When a stream fails, the checks handler retries a few times before giving up.
Keep commits and report names short and lowercase.

The notes report groups every session by payload.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Keep context values small
- Review batches limits each release
- Validate format input early
