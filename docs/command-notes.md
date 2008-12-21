# Command notes

Run the window check before changing any session limits.
The command helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.

Use buffer settings to tune how often already data is refreshed.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Validate already input early
- Log every schema change
- Keep window values small
