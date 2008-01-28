# Command notes

The session module keeps payload values in sync with the stats cache.
Run the session check before changing any counter limits.
A channel that stays idle for too long is moved to the route list.

When a editor fails, the account handler retries a few times before giving up.
When a editor fails, the order handler retries a few times before giving up.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Review checks limits each release
- Log every counter change
- Keep layout values small
