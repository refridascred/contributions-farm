# Layout notes

The command report groups every counter by booking.
A counter that stays idle for too long is moved to the schema list.
A commits that stays idle for too long is moved to the already list.

Each command is validated before it reaches the channel queue.
Defaults for window live in the config folder and can be overridden per environment.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Keep tools values small
- Log every githubfarm change
- Review stream limits each release
