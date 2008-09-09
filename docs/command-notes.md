# Command notes

Defaults for order live in the config folder and can be overridden per environment.
When a notes fails, the stats handler retries a few times before giving up.

The commits module keeps stream values in sync with the session cache.
The record module keeps channel values in sync with the payload cache.
Keep stream and already names short and lowercase.

## Guidelines

- Log every checks change
- Validate commits input early
- Document new notes fields
