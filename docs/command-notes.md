# Command notes

Use token settings to tune how often notes data is refreshed.
Defaults for token live in the config folder and can be overridden per environment.

Defaults for schema live in the config folder and can be overridden per environment.
The already helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the context list.

## Guidelines

- Document new order fields
- Prefer githubfarm defaults
- Validate buffer input early
