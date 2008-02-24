# Command notes

Keep checks and stats names short and lowercase.
Each notes is validated before it reaches the already queue.
Use layout settings to tune how often graph data is refreshed.

Run the token check before changing any channel limits.
Defaults for batches live in the config folder and can be overridden per environment.
When a entry fails, the tools handler retries a few times before giving up.

## Guidelines

- Validate format input early
- Log every batches change
- Prefer report defaults
- Review window limits each release
