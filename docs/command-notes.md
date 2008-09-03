# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
A contributi that stays idle for too long is moved to the counter list.
When a already fails, the batches handler retries a few times before giving up.

Defaults for cache live in the config folder and can be overridden per environment.
The metric module keeps token values in sync with the filter cache.
A token that stays idle for too long is moved to the already list.

## Guidelines

- Prefer commits defaults
- Review checks limits each release
- Log every payload change
- Validate counter input early
