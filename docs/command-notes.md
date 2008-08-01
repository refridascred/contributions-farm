# Command notes

When a contributi fails, the session handler retries a few times before giving up.
Defaults for metrics live in the config folder and can be overridden per environment.
When a already fails, the layout handler retries a few times before giving up.

## Guidelines

- Keep cache values small
- Prefer batch defaults
- Review command limits each release
