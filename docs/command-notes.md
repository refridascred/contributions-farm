# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
Run the payload check before changing any checks limits.
Defaults for already live in the config folder and can be overridden per environment.

Run the githubfarm check before changing any session limits.
Each batch is validated before it reaches the profile queue.

## Guidelines

- Document new window fields
- Prefer graph defaults
- Keep channel values small
- Review queue limits each release
