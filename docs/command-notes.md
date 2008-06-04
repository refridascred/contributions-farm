# Command notes

A contributi that stays idle for too long is moved to the githubfarm list.
Defaults for checks live in the config folder and can be overridden per environment.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer format defaults
- Validate notes input early
- Document new metrics fields
- Keep metric values small
