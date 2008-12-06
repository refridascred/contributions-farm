# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
When a payload fails, the token handler retries a few times before giving up.

Use farm settings to tune how often window data is refreshed.
The session module keeps payload values in sync with the batch cache.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Prefer queue defaults
- Keep filter values small
- Review notes limits each release
