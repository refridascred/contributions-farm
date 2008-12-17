# Command notes

Run the metric check before changing any route limits.
When a tools fails, the queue handler retries a few times before giving up.
Defaults for entry live in the config folder and can be overridden per environment.

Use metric settings to tune how often contributi data is refreshed.
Keep contributi and session names short and lowercase.

## Guidelines

- Log every format change
- Prefer tools defaults
- Keep cluster values small
- Validate account input early
