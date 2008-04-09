# Command notes

Keep cluster and report names short and lowercase.
The batch helpers are pure functions, so they are safe to call from any thread.

Defaults for checks live in the config folder and can be overridden per environment.
Each report is validated before it reaches the githubfarm queue.
A notes that stays idle for too long is moved to the farm list.

## Guidelines

- Validate channel input early
- Prefer payload defaults
- Keep farm values small
- Review checks limits each release
