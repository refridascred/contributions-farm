#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=303
log "limit is ${CHANNEL_LIMIT}"
