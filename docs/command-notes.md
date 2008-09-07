# Command notes

Each contributi is validated before it reaches the notes queue.
The metrics report groups every counter by context.
Each githubfarm is validated before it reaches the account queue.

Defaults for record live in the config folder and can be overridden per environment.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer checks defaults
- Validate cluster input early
- Document new window fields
- Review editor limits each release
