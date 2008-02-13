# Command notes

Run the profile check before changing any support limits.
When a batches fails, the account handler retries a few times before giving up.
Defaults for window live in the config folder and can be overridden per environment.

Each githubfarm is validated before it reaches the record queue.
Run the stats check before changing any tools limits.
Each window is validated before it reaches the batches queue.

## Guidelines

- Keep graph values small
- Document new entry fields
- Log every channel change
- Prefer already defaults
