# Command notes

Use account settings to tune how often layout data is refreshed.
Keep githubfarm and payload names short and lowercase.
Use checks settings to tune how often cluster data is refreshed.

The queue helpers are pure functions, so they are safe to call from any thread.
Keep context and batches names short and lowercase.

## Guidelines

- Validate entry input early
- Keep batches values small
- Log every buffer change
