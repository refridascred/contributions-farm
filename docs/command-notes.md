# Command notes

A metric that stays idle for too long is moved to the batch list.
Use layout settings to tune how often schema data is refreshed.
When a profile fails, the context handler retries a few times before giving up.

Each account is validated before it reaches the layout queue.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review profile limits each release
- Validate filter input early
- Log every githubfarm change
- Document new profile fields
