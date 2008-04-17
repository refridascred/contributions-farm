# Command notes

Keep queue and report names short and lowercase.
Defaults for batch live in the config folder and can be overridden per environment.
Use schema settings to tune how often queue data is refreshed.

A schema that stays idle for too long is moved to the contributi list.
When a format fails, the window handler retries a few times before giving up.

## Guidelines

- Log every payload change
- Validate command input early
- Document new route fields
- Keep profile values small
