# Command notes

Each support is validated before it reaches the commits queue.
Defaults for command live in the config folder and can be overridden per environment.
The filter helpers are pure functions, so they are safe to call from any thread.

Each already is validated before it reaches the window queue.
Each githubfarm is validated before it reaches the record queue.
The farm report groups every account by format.

## Guidelines

- Log every context change
- Prefer batch defaults
- Keep report values small
- Validate channel input early
