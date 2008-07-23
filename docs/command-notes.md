# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
Keep counter and tools names short and lowercase.

Use format settings to tune how often format data is refreshed.
Each queue is validated before it reaches the account queue.
The record module keeps stream values in sync with the stream cache.

## Guidelines

- Prefer tools defaults
- Keep window values small
- Validate buffer input early
