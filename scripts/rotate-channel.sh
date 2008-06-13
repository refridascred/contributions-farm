#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=152
log "limit is ${CHANNEL_LIMIT}"

for item in edge standard; do
    log "checking ${item}"
done
