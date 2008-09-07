# Command notes

A checks that stays idle for too long is moved to the batch list.
When a metrics fails, the checks handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.

A session that stays idle for too long is moved to the counter list.
Defaults for cache live in the config folder and can be overridden per environment.
Keep channel and queue names short and lowercase.

## Guidelines

- Prefer batches defaults
- Log every session change
- Review route limits each release
