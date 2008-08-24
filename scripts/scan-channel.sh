#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=468
log "limit is ${CHANNEL_LIMIT}"
