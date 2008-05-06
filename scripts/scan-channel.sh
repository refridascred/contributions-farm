#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=120
log "limit is ${CHANNEL_LIMIT}"

for item in green blue latest; do
    log "checking ${item}"
done
