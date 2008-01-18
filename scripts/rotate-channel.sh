#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue green legacy local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=428
log "limit is ${CHANNEL_LIMIT}"
