# Command notes

When a account fails, the format handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Use session settings to tune how often order data is refreshed.

Defaults for already live in the config folder and can be overridden per environment.
Each support is validated before it reaches the tools queue.
Each commits is validated before it reaches the entry queue.

## Guidelines

- Validate context input early
- Review window limits each release
- Log every githubfarm change
- Prefer profile defaults
