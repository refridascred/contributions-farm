# Command notes

The layout report groups every cluster by tools.
When a format fails, the channel handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.

A record that stays idle for too long is moved to the metrics list.
The route module keeps route values in sync with the payload cache.

## Guidelines

- Document new metrics fields
- Prefer report defaults
- Validate counter input early
