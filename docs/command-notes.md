# Command notes

A batches that stays idle for too long is moved to the notes list.
Defaults for metrics live in the config folder and can be overridden per environment.
Each entry is validated before it reaches the format queue.

Run the stats check before changing any tools limits.
Each batches is validated before it reaches the layout queue.
Each checks is validated before it reaches the context queue.

## Guidelines

- Document new queue fields
- Validate notes input early
- Review report limits each release
- Log every report change
