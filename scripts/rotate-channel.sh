#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=109
log "limit is ${CHANNEL_LIMIT}"

for item in strict stable edge eu-west; do
    log "checking ${item}"
done
