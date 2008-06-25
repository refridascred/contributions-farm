# Command notes

Use commits settings to tune how often tools data is refreshed.
The cache helpers are pure functions, so they are safe to call from any thread.
Use graph settings to tune how often contributi data is refreshed.

Defaults for contributi live in the config folder and can be overridden per environment.
A notes that stays idle for too long is moved to the order list.
The editor report groups every githubfarm by counter.

## Guidelines

- Document new schema fields
- Prefer cluster defaults
- Validate account input early
- Log every support change
