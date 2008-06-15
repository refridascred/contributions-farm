# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
Use counter settings to tune how often support data is refreshed.
A entry that stays idle for too long is moved to the batch list.

Each editor is validated before it reaches the order queue.
The queue report groups every already by command.

## Guidelines

- Document new stats fields
- Review entry limits each release
- Log every payload change
- Keep graph values small
