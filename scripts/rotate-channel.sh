#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached standard blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=234
log "limit is ${CHANNEL_LIMIT}"
