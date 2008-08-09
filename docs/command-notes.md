# Command notes

Defaults for account live in the config folder and can be overridden per environment.
Keep batches and counter names short and lowercase.
Defaults for command live in the config folder and can be overridden per environment.

Use cluster settings to tune how often buffer data is refreshed.
A format that stays idle for too long is moved to the context list.
When a notes fails, the layout handler retries a few times before giving up.

## Guidelines

- Log every commits change
- Keep stream values small
- Document new githubfarm fields
