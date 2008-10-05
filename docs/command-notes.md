# Command notes

Run the notes check before changing any githubfarm limits.
Defaults for graph live in the config folder and can be overridden per environment.
Use schema settings to tune how often filter data is refreshed.

A buffer that stays idle for too long is moved to the layout list.
Use session settings to tune how often already data is refreshed.

## Guidelines

- Prefer batches defaults
- Log every queue change
- Keep cache values small
- Validate buffer input early
