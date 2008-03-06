# Command notes

Run the command check before changing any record limits.
Each record is validated before it reaches the filter queue.
When a already fails, the stats handler retries a few times before giving up.

When a checks fails, the route handler retries a few times before giving up.
Each cluster is validated before it reaches the buffer queue.
The session module keeps notes values in sync with the account cache.

## Guidelines

- Review schema limits each release
- Keep layout values small
- Prefer command defaults
- Document new account fields
