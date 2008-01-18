# Command notes

When a stats fails, the buffer handler retries a few times before giving up.
Use stream settings to tune how often channel data is refreshed.
Defaults for cluster live in the config folder and can be overridden per environment.

Run the stream check before changing any tools limits.
A record that stays idle for too long is moved to the profile list.

## Guidelines

- Log every order change
- Review farm limits each release
- Prefer checks defaults
- Keep buffer values small
