#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=236
log "limit is ${CHANNEL_LIMIT}"

for item in blue latest; do
    log "checking ${item}"
done
