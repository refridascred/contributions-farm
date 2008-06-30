# Command notes

Use cluster settings to tune how often token data is refreshed.
Keep channel and order names short and lowercase.
Each record is validated before it reaches the account queue.

Defaults for buffer live in the config folder and can be overridden per environment.
Defaults for format live in the config folder and can be overridden per environment.
The profile module keeps cluster values in sync with the queue cache.

## Guidelines

- Keep counter values small
- Review editor limits each release
- Validate checks input early
- Log every cache change
