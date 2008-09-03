# Command notes

A record that stays idle for too long is moved to the checks list.
Run the editor check before changing any batch limits.
When a notes fails, the farm handler retries a few times before giving up.

Use record settings to tune how often checks data is refreshed.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Keep channel values small
- Log every order change
- Document new channel fields
- Review checks limits each release
