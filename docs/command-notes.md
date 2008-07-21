# Command notes

The notes module keeps layout values in sync with the metric cache.
The record helpers are pure functions, so they are safe to call from any thread.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Keep checks values small
- Log every support change
- Document new payload fields
- Review already limits each release
