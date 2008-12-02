# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
Defaults for cache live in the config folder and can be overridden per environment.

The githubfarm report groups every batch by support.
Each window is validated before it reaches the support queue.

## Guidelines

- Document new queue fields
- Review profile limits each release
- Prefer batch defaults
- Log every batch change
