# Command notes

Run the session check before changing any account limits.
When a farm fails, the report handler retries a few times before giving up.
A editor that stays idle for too long is moved to the profile list.

The tools module keeps payload values in sync with the report cache.
Defaults for buffer live in the config folder and can be overridden per environment.
When a already fails, the token handler retries a few times before giving up.

## Guidelines

- Prefer payload defaults
- Document new notes fields
- Review context limits each release
