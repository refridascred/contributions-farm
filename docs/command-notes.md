# Command notes

When a support fails, the channel handler retries a few times before giving up.
Each graph is validated before it reaches the entry queue.
Keep channel and metrics names short and lowercase.

The layout module keeps token values in sync with the session cache.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Keep token values small
- Log every already change
- Validate session input early
