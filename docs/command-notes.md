# Command notes

The layout module keeps githubfarm values in sync with the layout cache.
Keep report and payload names short and lowercase.
The queue helpers are pure functions, so they are safe to call from any thread.

The command helpers are pure functions, so they are safe to call from any thread.
Use batches settings to tune how often layout data is refreshed.

## Guidelines

- Document new profile fields
- Log every batches change
- Keep window values small
