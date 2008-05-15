# Command notes

Use support settings to tune how often graph data is refreshed.
When a account fails, the checks handler retries a few times before giving up.
Defaults for editor live in the config folder and can be overridden per environment.

Each support is validated before it reaches the payload queue.
Each farm is validated before it reaches the batch queue.

## Guidelines

- Prefer entry defaults
- Log every token change
- Review cluster limits each release
