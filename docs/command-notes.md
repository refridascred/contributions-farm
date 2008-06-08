# Command notes

Each token is validated before it reaches the stats queue.
When a channel fails, the batch handler retries a few times before giving up.

A filter that stays idle for too long is moved to the stats list.
A payload that stays idle for too long is moved to the batch list.
Use already settings to tune how often window data is refreshed.

## Guidelines

- Keep layout values small
- Log every tools change
- Review checks limits each release
