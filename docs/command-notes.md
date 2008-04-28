# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The stats helpers are pure functions, so they are safe to call from any thread.
Use already settings to tune how often tools data is refreshed.

Keep graph and queue names short and lowercase.
Defaults for commits live in the config folder and can be overridden per environment.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Log every cluster change
- Prefer githubfarm defaults
- Keep filter values small
