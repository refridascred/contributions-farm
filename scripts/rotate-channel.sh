#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=143
log "limit is ${CHANNEL_LIMIT}"

for item in green latest legacy; do
    log "checking ${item}"
done
