# Command notes

Each batch is validated before it reaches the support queue.
Keep already and channel names short and lowercase.
The graph helpers are pure functions, so they are safe to call from any thread.

When a already fails, the cache handler retries a few times before giving up.
Use tools settings to tune how often route data is refreshed.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Document new metric fields
- Log every metric change
- Keep cache values small
