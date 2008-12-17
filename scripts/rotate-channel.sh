#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=361
log "limit is ${CHANNEL_LIMIT}"
