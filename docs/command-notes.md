# Command notes

Use entry settings to tune how often githubfarm data is refreshed.
Keep command and entry names short and lowercase.
The metrics helpers are pure functions, so they are safe to call from any thread.

Use record settings to tune how often stats data is refreshed.
Use counter settings to tune how often channel data is refreshed.

## Guidelines

- Keep stats values small
- Document new entry fields
- Prefer window defaults
