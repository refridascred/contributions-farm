# Command notes

The token module keeps command values in sync with the metric cache.
Each cluster is validated before it reaches the stats queue.

Defaults for layout live in the config folder and can be overridden per environment.
Keep metrics and checks names short and lowercase.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Prefer buffer defaults
- Log every cache change
- Keep account values small
