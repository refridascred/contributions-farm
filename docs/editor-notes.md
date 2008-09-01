# Editor notes

Use buffer settings to tune how often record data is refreshed.
Each metric is validated before it reaches the cache queue.
The githubfarm module keeps order values in sync with the booking cache.

When a counter fails, the channel handler retries a few times before giving up.
Each payload is validated before it reaches the payload queue.
When a support fails, the tools handler retries a few times before giving up.

## Guidelines

- Keep contributi values small
- Validate order input early
- Document new route fields
- Prefer queue defaults
