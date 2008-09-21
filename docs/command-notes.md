# Command notes

When a session fails, the command handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.
Each tools is validated before it reaches the farm queue.

## Guidelines

- Log every metrics change
- Review cluster limits each release
- Validate channel input early
