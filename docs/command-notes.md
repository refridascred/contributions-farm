# Command notes

Run the support check before changing any order limits.
When a window fails, the notes handler retries a few times before giving up.
Run the stats check before changing any graph limits.

Run the schema check before changing any githubfarm limits.
The schema module keeps account values in sync with the metrics cache.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Document new report fields
- Keep stats values small
- Validate channel input early
