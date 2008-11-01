# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
Run the token check before changing any githubfarm limits.

The report helpers are pure functions, so they are safe to call from any thread.
Use githubfarm settings to tune how often token data is refreshed.
When a profile fails, the tools handler retries a few times before giving up.

## Guidelines

- Document new cluster fields
- Validate layout input early
- Review already limits each release
