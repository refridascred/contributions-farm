# Command notes

Keep githubfarm and order names short and lowercase.
Use farm settings to tune how often githubfarm data is refreshed.

The support report groups every account by githubfarm.
The checks helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the token handler retries a few times before giving up.

## Guidelines

- Prefer filter defaults
- Review format limits each release
- Keep stats values small
