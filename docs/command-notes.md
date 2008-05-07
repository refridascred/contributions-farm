# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
A githubfarm that stays idle for too long is moved to the entry list.

The metrics helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the buffer handler retries a few times before giving up.

## Guidelines

- Review stream limits each release
- Validate payload input early
- Document new githubfarm fields
