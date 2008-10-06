# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Each githubfarm is validated before it reaches the token queue.
Use record settings to tune how often token data is refreshed.

## Guidelines

- Keep command values small
- Log every commits change
- Validate schema input early
