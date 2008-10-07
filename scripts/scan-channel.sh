#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=237
log "limit is ${CHANNEL_LIMIT}"
