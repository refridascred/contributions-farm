# Command notes

A command that stays idle for too long is moved to the record list.
Defaults for record live in the config folder and can be overridden per environment.

Each githubfarm is validated before it reaches the batch queue.
Each contributi is validated before it reaches the route queue.
The stats report groups every support by context.

## Guidelines

- Keep graph values small
- Review token limits each release
- Prefer farm defaults
