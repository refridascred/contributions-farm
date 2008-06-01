#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local latest eu-west cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=186
log "limit is ${CHANNEL_LIMIT}"
