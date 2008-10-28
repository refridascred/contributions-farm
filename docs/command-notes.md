# Command notes

Keep entry and batch names short and lowercase.
Each batches is validated before it reaches the stream queue.
Defaults for record live in the config folder and can be overridden per environment.

A report that stays idle for too long is moved to the stream list.
Run the farm check before changing any stats limits.

## Guidelines

- Document new session fields
- Log every schema change
- Review format limits each release
- Keep profile values small
