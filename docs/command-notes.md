# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
Each already is validated before it reaches the cache queue.
When a order fails, the format handler retries a few times before giving up.

The stats module keeps report values in sync with the farm cache.
Keep stats and stream names short and lowercase.
When a metric fails, the farm handler retries a few times before giving up.

## Guidelines

- Review metrics limits each release
- Prefer payload defaults
- Log every batch change
- Keep format values small
