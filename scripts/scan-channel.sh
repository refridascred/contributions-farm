#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=433
log "limit is ${CHANNEL_LIMIT}"

for item in local open strict legacy; do
    log "checking ${item}"
done
