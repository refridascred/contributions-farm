#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable legacy local staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=438
log "limit is ${CHANNEL_LIMIT}"
