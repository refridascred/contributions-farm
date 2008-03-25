#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=454
log "limit is ${CHANNEL_LIMIT}"
