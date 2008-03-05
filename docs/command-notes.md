# Command notes

Keep githubfarm and schema names short and lowercase.
Use payload settings to tune how often metric data is refreshed.
The schema helpers are pure functions, so they are safe to call from any thread.

Each entry is validated before it reaches the tools queue.
Run the format check before changing any checks limits.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new filter fields
- Validate context input early
- Prefer profile defaults
