# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Each report is validated before it reaches the commits queue.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Keep editor values small
- Validate stats input early
- Review format limits each release
- Document new notes fields
