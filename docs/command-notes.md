# Command notes

A session that stays idle for too long is moved to the payload list.
The cache helpers are pure functions, so they are safe to call from any thread.
Run the token check before changing any stats limits.

Use profile settings to tune how often queue data is refreshed.
Keep command and format names short and lowercase.

## Guidelines

- Keep cluster values small
- Review stream limits each release
- Document new githubfarm fields
- Prefer format defaults
