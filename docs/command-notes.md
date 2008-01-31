# Command notes

Each profile is validated before it reaches the checks queue.
Use context settings to tune how often stream data is refreshed.
Run the account check before changing any account limits.

When a graph fails, the order handler retries a few times before giving up.
Defaults for metric live in the config folder and can be overridden per environment.
Each command is validated before it reaches the cache queue.

## Guidelines

- Document new batch fields
- Keep contributi values small
- Validate notes input early
