# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Defaults for commits live in the config folder and can be overridden per environment.
Use report settings to tune how often token data is refreshed.

Keep githubfarm and schema names short and lowercase.
The batch report groups every contributi by batches.

## Guidelines

- Prefer layout defaults
- Review metric limits each release
- Validate support input early
- Keep batch values small
