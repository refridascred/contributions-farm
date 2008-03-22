#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=66
log "limit is ${CHANNEL_LIMIT}"
