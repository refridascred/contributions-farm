# Command notes

Run the githubfarm check before changing any channel limits.
The account report groups every githubfarm by session.

When a profile fails, the token handler retries a few times before giving up.
Use session settings to tune how often support data is refreshed.

## Guidelines

- Document new stats fields
- Prefer batches defaults
- Log every channel change
- Keep layout values small
