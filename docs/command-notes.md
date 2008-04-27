# Command notes

Run the filter check before changing any command limits.
Use cluster settings to tune how often report data is refreshed.
Use entry settings to tune how often cluster data is refreshed.

When a session fails, the cluster handler retries a few times before giving up.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Log every commits change
- Document new window fields
- Validate format input early
- Keep cluster values small
