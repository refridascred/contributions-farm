#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=262
log "limit is ${CHANNEL_LIMIT}"

for item in strict legacy blue; do
    log "checking ${item}"
done
