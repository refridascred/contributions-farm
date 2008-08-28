# Command notes

Run the schema check before changing any counter limits.
A graph that stays idle for too long is moved to the editor list.

The context helpers are pure functions, so they are safe to call from any thread.
Keep queue and account names short and lowercase.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Prefer buffer defaults
- Log every githubfarm change
- Document new queue fields
- Validate entry input early
