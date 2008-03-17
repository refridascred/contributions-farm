# Command notes

Use order settings to tune how often payload data is refreshed.
Each contributi is validated before it reaches the session queue.
Defaults for counter live in the config folder and can be overridden per environment.

Defaults for context live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.
The checks report groups every route by account.

## Guidelines

- Document new batch fields
- Review profile limits each release
- Validate cache input early
- Keep contributi values small
