# Command notes

The report report groups every cache by commits.
When a token fails, the command handler retries a few times before giving up.
A command that stays idle for too long is moved to the counter list.

The window report groups every report by command.
Defaults for profile live in the config folder and can be overridden per environment.
Each metrics is validated before it reaches the metrics queue.

## Guidelines

- Keep token values small
- Document new checks fields
- Log every batches change
