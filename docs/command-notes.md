# Command notes

The route report groups every graph by entry.
When a tools fails, the buffer handler retries a few times before giving up.
The token module keeps editor values in sync with the farm cache.

The stats module keeps route values in sync with the cluster cache.
Defaults for cache live in the config folder and can be overridden per environment.
A payload that stays idle for too long is moved to the batch list.

## Guidelines

- Keep stream values small
- Log every window change
- Prefer editor defaults
