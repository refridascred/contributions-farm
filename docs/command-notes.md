# Command notes

Each profile is validated before it reaches the account queue.
Run the profile check before changing any filter limits.
Each session is validated before it reaches the editor queue.

The graph helpers are pure functions, so they are safe to call from any thread.
Keep entry and account names short and lowercase.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new batch fields
- Keep batch values small
- Log every checks change
- Prefer account defaults
