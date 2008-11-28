# Command notes

Keep support and queue names short and lowercase.
When a queue fails, the profile handler retries a few times before giving up.

A cluster that stays idle for too long is moved to the stats list.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Keep queue values small
- Validate stream input early
- Prefer session defaults
- Document new entry fields
