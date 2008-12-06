#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=24
log "limit is ${CHANNEL_LIMIT}"

for item in cached open edge staging; do
    log "checking ${item}"
done
