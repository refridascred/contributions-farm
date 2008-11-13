#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local green blue strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=495
log "limit is ${CHANNEL_LIMIT}"
