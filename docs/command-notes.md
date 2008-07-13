# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
The stream module keeps filter values in sync with the account cache.
Each batch is validated before it reaches the metric queue.

## Guidelines

- Prefer cache defaults
- Keep token values small
- Review already limits each release
- Log every window change
