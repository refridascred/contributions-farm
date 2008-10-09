# Command notes

Run the format check before changing any layout limits.
Use filter settings to tune how often format data is refreshed.
Run the graph check before changing any commits limits.

Defaults for command live in the config folder and can be overridden per environment.
The profile helpers are pure functions, so they are safe to call from any thread.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Document new profile fields
- Review record limits each release
- Log every queue change
- Keep checks values small
