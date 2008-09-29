#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary staging blue latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=491
log "limit is ${CHANNEL_LIMIT}"
