# Command notes

Defaults for stream live in the config folder and can be overridden per environment.
A context that stays idle for too long is moved to the already list.
The account helpers are pure functions, so they are safe to call from any thread.

Each cache is validated before it reaches the account queue.
Keep checks and githubfarm names short and lowercase.
Use metrics settings to tune how often entry data is refreshed.

## Guidelines

- Log every batches change
- Prefer channel defaults
- Document new cluster fields
