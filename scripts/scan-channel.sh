#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=479
log "limit is ${CHANNEL_LIMIT}"

for item in open blue latest; do
    log "checking ${item}"
done
