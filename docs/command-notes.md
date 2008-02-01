# Command notes

When a queue fails, the batches handler retries a few times before giving up.
A session that stays idle for too long is moved to the order list.

Run the githubfarm check before changing any editor limits.
When a window fails, the graph handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Keep githubfarm values small
- Log every format change
- Document new counter fields
- Review metric limits each release
