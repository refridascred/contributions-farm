# Command notes

When a channel fails, the layout handler retries a few times before giving up.
Defaults for layout live in the config folder and can be overridden per environment.

A token that stays idle for too long is moved to the entry list.
Run the report check before changing any schema limits.

## Guidelines

- Document new schema fields
- Prefer githubfarm defaults
- Keep layout values small
- Review session limits each release
