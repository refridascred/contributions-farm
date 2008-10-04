# Command notes

Keep cluster and filter names short and lowercase.
Defaults for format live in the config folder and can be overridden per environment.

Each buffer is validated before it reaches the stats queue.
Each buffer is validated before it reaches the channel queue.
Each notes is validated before it reaches the stats queue.

## Guidelines

- Log every farm change
- Validate stream input early
- Document new support fields
- Prefer stats defaults
