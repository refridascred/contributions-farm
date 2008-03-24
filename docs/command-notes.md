# Command notes

Defaults for editor live in the config folder and can be overridden per environment.
The window helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often batch data is refreshed.

Use editor settings to tune how often batch data is refreshed.
Each support is validated before it reaches the payload queue.
The record module keeps filter values in sync with the support cache.

## Guidelines

- Document new channel fields
- Validate commits input early
- Review graph limits each release
- Keep session values small
