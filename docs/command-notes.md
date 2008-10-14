# Command notes

A cache that stays idle for too long is moved to the checks list.
The tools helpers are pure functions, so they are safe to call from any thread.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Document new cluster fields
- Validate channel input early
- Review entry limits each release
