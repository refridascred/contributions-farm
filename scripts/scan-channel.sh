#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=194
log "limit is ${CHANNEL_LIMIT}"
