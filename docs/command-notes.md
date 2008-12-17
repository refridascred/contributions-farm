# Command notes

Keep metric and buffer names short and lowercase.
Use farm settings to tune how often format data is refreshed.
Each entry is validated before it reaches the window queue.

Use channel settings to tune how often editor data is refreshed.
Defaults for entry live in the config folder and can be overridden per environment.
The layout module keeps order values in sync with the metric cache.

## Guidelines

- Log every profile change
- Document new account fields
- Keep account values small
- Validate record input early
