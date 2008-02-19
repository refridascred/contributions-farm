#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=373
log "limit is ${CHANNEL_LIMIT}"
