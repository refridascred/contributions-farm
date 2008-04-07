# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Keep token and session names short and lowercase.

Use profile settings to tune how often farm data is refreshed.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Keep metrics values small
- Review session limits each release
- Log every session change
