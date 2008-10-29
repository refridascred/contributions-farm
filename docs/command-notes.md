# Command notes

A queue that stays idle for too long is moved to the session list.
The command report groups every tools by buffer.

The commits module keeps entry values in sync with the report cache.
Each counter is validated before it reaches the batch queue.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Prefer command defaults
- Validate contributi input early
- Log every graph change
