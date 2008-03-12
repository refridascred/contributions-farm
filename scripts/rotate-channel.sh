#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy local staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=304
log "limit is ${CHANNEL_LIMIT}"
