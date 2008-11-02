# Command notes

The metric module keeps account values in sync with the account cache.
Use format settings to tune how often layout data is refreshed.
Keep batch and context names short and lowercase.

Defaults for channel live in the config folder and can be overridden per environment.
The counter report groups every batches by entry.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cluster input early
- Keep batch values small
- Log every format change
- Prefer command defaults
