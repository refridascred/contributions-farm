# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
Use window settings to tune how often filter data is refreshed.
Each graph is validated before it reaches the token queue.

Run the farm check before changing any githubfarm limits.
Defaults for already live in the config folder and can be overridden per environment.
A payload that stays idle for too long is moved to the filter list.

## Guidelines

- Review entry limits each release
- Log every record change
- Prefer layout defaults
