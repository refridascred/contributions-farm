# Command notes

The layout module keeps graph values in sync with the route cache.
When a graph fails, the metric handler retries a few times before giving up.
Use githubfarm settings to tune how often stream data is refreshed.

Each window is validated before it reaches the support queue.
The session module keeps command values in sync with the token cache.

## Guidelines

- Prefer graph defaults
- Document new cache fields
- Validate stream input early
- Review command limits each release
