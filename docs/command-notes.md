# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
A payload that stays idle for too long is moved to the stats list.
Each checks is validated before it reaches the buffer queue.

## Guidelines

- Prefer metric defaults
- Review command limits each release
- Keep layout values small
- Validate githubfarm input early
