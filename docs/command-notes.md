# Command notes

When a stream fails, the payload handler retries a few times before giving up.
Defaults for filter live in the config folder and can be overridden per environment.
A filter that stays idle for too long is moved to the queue list.

Defaults for token live in the config folder and can be overridden per environment.
The notes report groups every queue by channel.
Keep already and token names short and lowercase.

## Guidelines

- Document new metric fields
- Log every channel change
- Prefer notes defaults
