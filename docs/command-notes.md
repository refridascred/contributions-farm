# Command notes

Use editor settings to tune how often token data is refreshed.
Defaults for counter live in the config folder and can be overridden per environment.

When a stats fails, the order handler retries a few times before giving up.
Each batches is validated before it reaches the metric queue.

## Guidelines

- Keep githubfarm values small
- Prefer stats defaults
- Review editor limits each release
- Log every cache change
