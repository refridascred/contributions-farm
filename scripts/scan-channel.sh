#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=456
log "limit is ${CHANNEL_LIMIT}"

for item in staging strict latest; do
    log "checking ${item}"
done
