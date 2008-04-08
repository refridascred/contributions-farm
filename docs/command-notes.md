# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the cluster handler retries a few times before giving up.

Each cache is validated before it reaches the profile queue.
Use schema settings to tune how often window data is refreshed.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep schema values small
- Document new tools fields
- Log every schema change
