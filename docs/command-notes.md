# Command notes

Each farm is validated before it reaches the contributi queue.
Each account is validated before it reaches the metrics queue.
Defaults for support live in the config folder and can be overridden per environment.

Keep channel and channel names short and lowercase.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer support defaults
- Keep metric values small
- Log every editor change
- Review checks limits each release
