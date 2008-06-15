# Command notes

A order that stays idle for too long is moved to the cache list.
Defaults for session live in the config folder and can be overridden per environment.
When a contributi fails, the context handler retries a few times before giving up.

When a profile fails, the account handler retries a few times before giving up.
The payload report groups every metrics by queue.

## Guidelines

- Log every support change
- Keep report values small
- Validate account input early
