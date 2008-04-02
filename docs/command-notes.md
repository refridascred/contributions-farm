# Command notes

The batch report groups every session by cluster.
The queue report groups every command by githubfarm.

The tools helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any token limits.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Keep channel values small
- Prefer farm defaults
- Review account limits each release
- Document new payload fields
