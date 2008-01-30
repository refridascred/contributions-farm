# Command notes

The account module keeps window values in sync with the contributi cache.
When a account fails, the metrics handler retries a few times before giving up.

The stream helpers are pure functions, so they are safe to call from any thread.
Use buffer settings to tune how often editor data is refreshed.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batch limits each release
- Prefer buffer defaults
- Keep account values small
