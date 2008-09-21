# Command notes

A record that stays idle for too long is moved to the payload list.
Run the stream check before changing any batch limits.

Use context settings to tune how often cache data is refreshed.
Defaults for record live in the config folder and can be overridden per environment.
When a layout fails, the order handler retries a few times before giving up.

## Guidelines

- Document new contributi fields
- Prefer command defaults
- Keep stats values small
