# Command notes

Use counter settings to tune how often record data is refreshed.
Keep record and cluster names short and lowercase.
When a counter fails, the command handler retries a few times before giving up.

Use record settings to tune how often commits data is refreshed.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Log every githubfarm change
- Validate schema input early
- Prefer record defaults
- Keep filter values small
