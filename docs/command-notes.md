# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.

Keep token and farm names short and lowercase.
Use commits settings to tune how often buffer data is refreshed.

## Guidelines

- Log every route change
- Keep cluster values small
- Document new cache fields
