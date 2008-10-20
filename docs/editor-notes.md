# Editor notes

Run the window check before changing any stream limits.
Use booking settings to tune how often session data is refreshed.
Each stats is validated before it reaches the filter queue.

Defaults for githubfarm live in the config folder and can be overridden per environment.
When a command fails, the tools handler retries a few times before giving up.

## Guidelines

- Review token limits each release
- Document new metrics fields
- Keep token values small
