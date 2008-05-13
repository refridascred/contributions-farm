# Command notes

Keep stats and metric names short and lowercase.
Run the stats check before changing any channel limits.
When a githubfarm fails, the queue handler retries a few times before giving up.

The report report groups every schema by githubfarm.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Document new command fields
- Keep queue values small
- Prefer metric defaults
