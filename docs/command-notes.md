# Command notes

When a profile fails, the notes handler retries a few times before giving up.
A cluster that stays idle for too long is moved to the schema list.

Each notes is validated before it reaches the schema queue.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Review window limits each release
- Keep stream values small
- Log every payload change
