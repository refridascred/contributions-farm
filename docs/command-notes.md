# Command notes

Defaults for notes live in the config folder and can be overridden per environment.
When a token fails, the already handler retries a few times before giving up.

The route report groups every window by githubfarm.
A githubfarm that stays idle for too long is moved to the route list.

## Guidelines

- Log every queue change
- Review support limits each release
- Validate window input early
- Document new queue fields
