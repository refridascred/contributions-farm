# Command notes

Keep githubfarm and checks names short and lowercase.
Each batches is validated before it reaches the contributi queue.
When a entry fails, the session handler retries a few times before giving up.

The payload report groups every contributi by profile.
The schema module keeps metrics values in sync with the token cache.
Use account settings to tune how often commits data is refreshed.

## Guidelines

- Document new farm fields
- Review account limits each release
- Prefer cache defaults
