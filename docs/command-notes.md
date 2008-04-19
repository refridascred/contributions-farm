# Command notes

Use notes settings to tune how often metrics data is refreshed.
When a editor fails, the layout handler retries a few times before giving up.
A already that stays idle for too long is moved to the batches list.

The cluster module keeps command values in sync with the checks cache.
The githubfarm module keeps farm values in sync with the contributi cache.

## Guidelines

- Prefer command defaults
- Review cache limits each release
- Document new checks fields
