# Command notes

Each commits is validated before it reaches the githubfarm queue.
The profile helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the counter list.

Use filter settings to tune how often notes data is refreshed.
Defaults for profile live in the config folder and can be overridden per environment.
A schema that stays idle for too long is moved to the window list.

## Guidelines

- Log every queue change
- Prefer already defaults
- Validate entry input early
