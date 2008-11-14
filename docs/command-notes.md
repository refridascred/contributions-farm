# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
Run the batch check before changing any metrics limits.

Each entry is validated before it reaches the layout queue.
Each record is validated before it reaches the stats queue.

## Guidelines

- Log every tools change
- Validate session input early
- Keep layout values small
