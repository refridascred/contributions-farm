# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
A route that stays idle for too long is moved to the session list.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Document new buffer fields
- Keep layout values small
- Review layout limits each release
