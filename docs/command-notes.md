# Command notes

Use already settings to tune how often batches data is refreshed.
Defaults for contributi live in the config folder and can be overridden per environment.

Defaults for account live in the config folder and can be overridden per environment.
The stream report groups every support by queue.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batches values small
- Validate batches input early
- Review profile limits each release
- Prefer contributi defaults
