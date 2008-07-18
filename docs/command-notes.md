# Command notes

Use checks settings to tune how often schema data is refreshed.
Run the channel check before changing any already limits.
Run the stream check before changing any report limits.

Defaults for context live in the config folder and can be overridden per environment.
Keep batch and graph names short and lowercase.
When a farm fails, the queue handler retries a few times before giving up.

## Guidelines

- Prefer metric defaults
- Document new payload fields
- Log every queue change
- Validate githubfarm input early
