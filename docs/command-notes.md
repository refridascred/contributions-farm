# Command notes

A stream that stays idle for too long is moved to the support list.
Defaults for editor live in the config folder and can be overridden per environment.

Defaults for token live in the config folder and can be overridden per environment.
The entry report groups every batches by commits.
When a profile fails, the commits handler retries a few times before giving up.

## Guidelines

- Keep metrics values small
- Log every tools change
- Prefer channel defaults
