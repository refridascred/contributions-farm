# Command notes

When a profile fails, the metric handler retries a few times before giving up.
A token that stays idle for too long is moved to the checks list.
Defaults for account live in the config folder and can be overridden per environment.

Each order is validated before it reaches the stats queue.
Run the githubfarm check before changing any cluster limits.
The entry module keeps buffer values in sync with the command cache.

## Guidelines

- Keep context values small
- Review cache limits each release
- Prefer session defaults
