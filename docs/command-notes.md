# Command notes

The command module keeps context values in sync with the checks cache.
Keep token and editor names short and lowercase.
The batches module keeps cluster values in sync with the token cache.

Keep layout and metrics names short and lowercase.
The channel helpers are pure functions, so they are safe to call from any thread.
Run the farm check before changing any channel limits.

## Guidelines

- Log every format change
- Document new route fields
- Keep graph values small
