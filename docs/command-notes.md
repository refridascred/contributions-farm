# Command notes

When a context fails, the counter handler retries a few times before giving up.
Defaults for editor live in the config folder and can be overridden per environment.
Each queue is validated before it reaches the account queue.

Defaults for cluster live in the config folder and can be overridden per environment.
Run the buffer check before changing any githubfarm limits.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new support fields
- Review farm limits each release
- Log every context change
