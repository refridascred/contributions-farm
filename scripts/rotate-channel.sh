#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=482
log "limit is ${CHANNEL_LIMIT}"

for item in primary edge; do
    log "checking ${item}"
done
