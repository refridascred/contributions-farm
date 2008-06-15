# Command notes

Run the context check before changing any command limits.
Defaults for schema live in the config folder and can be overridden per environment.
Run the tools check before changing any githubfarm limits.

Keep farm and notes names short and lowercase.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new contributi fields
- Keep batch values small
- Log every filter change
