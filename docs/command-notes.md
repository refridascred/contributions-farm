# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Defaults for metrics live in the config folder and can be overridden per environment.
The tools module keeps token values in sync with the githubfarm cache.

Keep batch and layout names short and lowercase.
Each tools is validated before it reaches the editor queue.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer report defaults
- Document new commits fields
- Keep cache values small
