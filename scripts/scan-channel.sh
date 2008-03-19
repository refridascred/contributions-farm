#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=14
log "limit is ${CHANNEL_LIMIT}"
