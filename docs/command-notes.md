# Command notes

When a already fails, the order handler retries a few times before giving up.
Each report is validated before it reaches the command queue.
Use token settings to tune how often stream data is refreshed.

Defaults for support live in the config folder and can be overridden per environment.
A batch that stays idle for too long is moved to the cluster list.

## Guidelines

- Document new queue fields
- Keep payload values small
- Log every account change
- Review stats limits each release
