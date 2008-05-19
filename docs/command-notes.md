# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
When a profile fails, the profile handler retries a few times before giving up.
Each tools is validated before it reaches the editor queue.

Use queue settings to tune how often editor data is refreshed.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Validate batches input early
- Keep layout values small
- Document new record fields
- Log every command change
