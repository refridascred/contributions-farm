# Command notes

Keep queue and filter names short and lowercase.
Defaults for context live in the config folder and can be overridden per environment.
Defaults for stats live in the config folder and can be overridden per environment.

When a githubfarm fails, the token handler retries a few times before giving up.
Each stats is validated before it reaches the account queue.
Use support settings to tune how often queue data is refreshed.

## Guidelines

- Document new order fields
- Prefer cluster defaults
- Keep queue values small
