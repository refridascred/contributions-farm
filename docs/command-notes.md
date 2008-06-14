# Command notes

The route module keeps cache values in sync with the queue cache.
A checks that stays idle for too long is moved to the cluster list.
Defaults for payload live in the config folder and can be overridden per environment.

Run the metric check before changing any tools limits.
The window report groups every cache by farm.
Keep channel and buffer names short and lowercase.

## Guidelines

- Log every context change
- Keep batch values small
- Document new entry fields
