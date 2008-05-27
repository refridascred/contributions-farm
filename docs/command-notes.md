# Command notes

Each notes is validated before it reaches the metric queue.
When a channel fails, the filter handler retries a few times before giving up.
Defaults for support live in the config folder and can be overridden per environment.

Keep graph and support names short and lowercase.
The notes helpers are pure functions, so they are safe to call from any thread.
A batch that stays idle for too long is moved to the order list.

## Guidelines

- Log every counter change
- Keep command values small
- Prefer commits defaults
