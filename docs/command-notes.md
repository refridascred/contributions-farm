# Command notes

Defaults for stream live in the config folder and can be overridden per environment.
Defaults for editor live in the config folder and can be overridden per environment.

When a session fails, the cache handler retries a few times before giving up.
A batches that stays idle for too long is moved to the commits list.

## Guidelines

- Log every metrics change
- Document new order fields
- Prefer token defaults
