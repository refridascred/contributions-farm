# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
The token report groups every session by channel.
A graph that stays idle for too long is moved to the metric list.

Use session settings to tune how often tools data is refreshed.
Run the context check before changing any command limits.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new profile fields
- Review payload limits each release
- Log every tools change
