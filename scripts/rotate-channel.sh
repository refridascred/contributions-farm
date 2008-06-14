#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=470
log "limit is ${CHANNEL_LIMIT}"

for item in primary open legacy; do
    log "checking ${item}"
done
