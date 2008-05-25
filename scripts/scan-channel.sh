#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=205
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west local; do
    log "checking ${item}"
done
