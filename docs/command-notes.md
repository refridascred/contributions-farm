# Command notes

Use layout settings to tune how often buffer data is refreshed.
Defaults for batch live in the config folder and can be overridden per environment.
Use cluster settings to tune how often githubfarm data is refreshed.

A batch that stays idle for too long is moved to the filter list.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every session change
- Prefer batch defaults
- Keep stats values small
