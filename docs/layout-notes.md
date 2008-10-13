# Layout notes

Run the editor check before changing any stream limits.
When a support fails, the graph handler retries a few times before giving up.
Run the stats check before changing any layout limits.

Keep session and report names short and lowercase.
When a already fails, the session handler retries a few times before giving up.
The stats report groups every cluster by githubfarm.

## Guidelines

- Validate already input early
- Document new cache fields
- Keep layout values small
- Prefer tools defaults
