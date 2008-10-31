# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Each context is validated before it reaches the session queue.
The already module keeps cache values in sync with the format cache.

The tools module keeps cache values in sync with the account cache.
Run the layout check before changing any already limits.
The stream module keeps tools values in sync with the contributi cache.

## Guidelines

- Review notes limits each release
- Validate support input early
- Keep channel values small
- Prefer batch defaults
