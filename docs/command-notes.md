# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
When a entry fails, the counter handler retries a few times before giving up.

Each metric is validated before it reaches the counter queue.
The window module keeps command values in sync with the entry cache.
When a githubfarm fails, the cache handler retries a few times before giving up.

## Guidelines

- Log every counter change
- Keep metrics values small
- Review commits limits each release
- Validate notes input early
