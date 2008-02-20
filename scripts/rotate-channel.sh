#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary stable edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=169
log "limit is ${CHANNEL_LIMIT}"
