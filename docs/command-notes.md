# Command notes

Run the tools check before changing any metrics limits.
Each order is validated before it reaches the command queue.
Keep contributi and support names short and lowercase.

The entry report groups every notes by account.
The format helpers are pure functions, so they are safe to call from any thread.
The batch module keeps contributi values in sync with the profile cache.

## Guidelines

- Validate cluster input early
- Log every payload change
- Keep cluster values small
- Prefer buffer defaults
