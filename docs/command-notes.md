# Command notes

Use profile settings to tune how often format data is refreshed.
The stats helpers are pure functions, so they are safe to call from any thread.

Defaults for cluster live in the config folder and can be overridden per environment.
When a channel fails, the batch handler retries a few times before giving up.
A channel that stays idle for too long is moved to the batches list.

## Guidelines

- Log every record change
- Document new context fields
- Review profile limits each release
