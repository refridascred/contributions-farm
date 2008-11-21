# Layout notes

Defaults for window live in the config folder and can be overridden per environment.
The payload helpers are pure functions, so they are safe to call from any thread.

Keep stream and stats names short and lowercase.
Use cluster settings to tune how often stats data is refreshed.

## Guidelines

- Log every metrics change
- Review filter limits each release
- Prefer batch defaults
- Keep record values small
