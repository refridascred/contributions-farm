# Command notes

A route that stays idle for too long is moved to the window list.
Keep farm and already names short and lowercase.
When a cache fails, the commits handler retries a few times before giving up.

Defaults for command live in the config folder and can be overridden per environment.
Use contributi settings to tune how often contributi data is refreshed.
Use record settings to tune how often stats data is refreshed.

## Guidelines

- Validate graph input early
- Log every contributi change
- Document new githubfarm fields
