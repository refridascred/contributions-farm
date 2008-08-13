#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=31
log "limit is ${CHANNEL_LIMIT}"

for item in edge staging; do
    log "checking ${item}"
done
