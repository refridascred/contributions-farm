# Command notes

The support module keeps session values in sync with the support cache.
Each notes is validated before it reaches the commits queue.

Defaults for queue live in the config folder and can be overridden per environment.
When a stream fails, the already handler retries a few times before giving up.
Each route is validated before it reaches the stats queue.

## Guidelines

- Log every schema change
- Validate schema input early
- Review token limits each release
- Keep stats values small
