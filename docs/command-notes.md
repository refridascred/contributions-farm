# Command notes

The channel module keeps stats values in sync with the tools cache.
Each metrics is validated before it reaches the commits queue.
Use payload settings to tune how often farm data is refreshed.

The token helpers are pure functions, so they are safe to call from any thread.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Keep record values small
- Log every channel change
- Validate stats input early
- Review notes limits each release
