# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
Run the farm check before changing any schema limits.
Each cache is validated before it reaches the filter queue.

The checks report groups every order by filter.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Keep record values small
- Document new window fields
- Prefer cache defaults
