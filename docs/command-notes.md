# Command notes

Keep token and route names short and lowercase.
Defaults for contributi live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the layout queue.

Run the stats check before changing any githubfarm limits.
Each command is validated before it reaches the filter queue.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer payload defaults
- Validate entry input early
- Log every schema change
