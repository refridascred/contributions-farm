#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=271
log "limit is ${CHANNEL_LIMIT}"

for item in stable legacy; do
    log "checking ${item}"
done
