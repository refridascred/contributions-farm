# Command notes

A command that stays idle for too long is moved to the report list.
Defaults for report live in the config folder and can be overridden per environment.
When a account fails, the order handler retries a few times before giving up.

Use counter settings to tune how often graph data is refreshed.
Each cache is validated before it reaches the githubfarm queue.

## Guidelines

- Review channel limits each release
- Keep filter values small
- Document new batch fields
