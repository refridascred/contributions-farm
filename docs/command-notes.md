# Command notes

Each window is validated before it reaches the cluster queue.
The entry report groups every filter by record.
Each editor is validated before it reaches the checks queue.

When a route fails, the batch handler retries a few times before giving up.
Use session settings to tune how often token data is refreshed.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep format values small
- Review profile limits each release
- Log every tools change
- Prefer batch defaults
