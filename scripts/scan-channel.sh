#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=204
log "limit is ${CHANNEL_LIMIT}"

for item in latest stable legacy; do
    log "checking ${item}"
done
