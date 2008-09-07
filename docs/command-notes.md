# Command notes

The notes module keeps schema values in sync with the metrics cache.
Each record is validated before it reaches the metrics queue.
Keep editor and cluster names short and lowercase.

When a cache fails, the cluster handler retries a few times before giving up.
Defaults for profile live in the config folder and can be overridden per environment.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Review channel limits each release
- Keep metric values small
- Validate payload input early
