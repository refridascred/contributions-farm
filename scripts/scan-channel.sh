#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary strict legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=423
log "limit is ${CHANNEL_LIMIT}"
