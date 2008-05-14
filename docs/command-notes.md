# Command notes

Run the checks check before changing any entry limits.
A layout that stays idle for too long is moved to the checks list.
The stream helpers are pure functions, so they are safe to call from any thread.

Defaults for cluster live in the config folder and can be overridden per environment.
Run the metrics check before changing any entry limits.

## Guidelines

- Review report limits each release
- Validate queue input early
- Document new metric fields
- Keep counter values small
