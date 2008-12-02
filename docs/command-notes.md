# Command notes

Each checks is validated before it reaches the filter queue.
Each payload is validated before it reaches the metrics queue.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Log every record change
- Keep githubfarm values small
- Prefer channel defaults
- Validate notes input early
