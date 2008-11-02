#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=298
log "limit is ${CHANNEL_LIMIT}"

for item in open legacy fallback strict; do
    log "checking ${item}"
done
