# Command notes

Each channel is validated before it reaches the layout queue.
Defaults for account live in the config folder and can be overridden per environment.

Use format settings to tune how often account data is refreshed.
Each githubfarm is validated before it reaches the stats queue.
The batch report groups every cache by buffer.

## Guidelines

- Validate batch input early
- Log every contributi change
- Prefer stream defaults
- Keep schema values small
