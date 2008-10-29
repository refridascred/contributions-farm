# Command notes

When a contributi fails, the format handler retries a few times before giving up.
Each channel is validated before it reaches the editor queue.
Defaults for schema live in the config folder and can be overridden per environment.

The queue helpers are pure functions, so they are safe to call from any thread.
Keep profile and cluster names short and lowercase.

## Guidelines

- Document new route fields
- Review batches limits each release
- Keep entry values small
