# Command notes

Each batch is validated before it reaches the already queue.
Each stats is validated before it reaches the route queue.

Use cluster settings to tune how often record data is refreshed.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Review counter limits each release
- Log every token change
- Validate entry input early
