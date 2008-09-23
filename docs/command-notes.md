# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for metrics live in the config folder and can be overridden per environment.
Run the editor check before changing any metrics limits.

Keep checks and record names short and lowercase.
The context module keeps token values in sync with the farm cache.
Each cache is validated before it reaches the cache queue.

## Guidelines

- Document new editor fields
- Review record limits each release
- Keep profile values small
