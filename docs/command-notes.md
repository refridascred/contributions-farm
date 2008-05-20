# Command notes

Keep contributi and queue names short and lowercase.
Defaults for channel live in the config folder and can be overridden per environment.

Each queue is validated before it reaches the editor queue.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review queue limits each release
- Log every schema change
- Keep session values small
- Document new cluster fields
