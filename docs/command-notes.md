# Command notes

Run the context check before changing any report limits.
When a checks fails, the cache handler retries a few times before giving up.
The filter report groups every channel by profile.

Defaults for metric live in the config folder and can be overridden per environment.
A cache that stays idle for too long is moved to the batch list.

## Guidelines

- Document new already fields
- Review cache limits each release
- Validate cluster input early
- Prefer tools defaults
