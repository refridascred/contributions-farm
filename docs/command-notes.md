# Command notes

Run the payload check before changing any support limits.
Each session is validated before it reaches the payload queue.

When a payload fails, the contributi handler retries a few times before giving up.
The checks module keeps filter values in sync with the profile cache.
Run the contributi check before changing any editor limits.

## Guidelines

- Log every githubfarm change
- Prefer format defaults
- Review already limits each release
- Keep farm values small
