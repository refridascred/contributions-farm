#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy standard edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=29
log "limit is ${CHANNEL_LIMIT}"
