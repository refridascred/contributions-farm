# Command notes

The command report groups every counter by notes.
A metrics that stays idle for too long is moved to the entry list.

Each format is validated before it reaches the command queue.
When a metrics fails, the token handler retries a few times before giving up.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Document new stream fields
- Validate batches input early
- Keep support values small
- Log every metrics change
