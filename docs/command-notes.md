# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
Use batches settings to tune how often report data is refreshed.

A batch that stays idle for too long is moved to the batches list.
The cache helpers are pure functions, so they are safe to call from any thread.
Use cache settings to tune how often editor data is refreshed.

## Guidelines

- Keep batches values small
- Review commits limits each release
- Log every queue change
