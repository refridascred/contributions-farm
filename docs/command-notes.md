# Command notes

When a stats fails, the queue handler retries a few times before giving up.
A queue that stays idle for too long is moved to the order list.

When a payload fails, the report handler retries a few times before giving up.
Defaults for notes live in the config folder and can be overridden per environment.
The cache module keeps editor values in sync with the route cache.

## Guidelines

- Prefer layout defaults
- Keep schema values small
- Document new filter fields
- Review editor limits each release
