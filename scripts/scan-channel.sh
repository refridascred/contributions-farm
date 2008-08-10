#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=239
log "limit is ${CHANNEL_LIMIT}"

for item in stable local cached latest; do
    log "checking ${item}"
done
