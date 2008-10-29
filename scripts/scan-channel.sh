#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=59
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west primary local latest; do
    log "checking ${item}"
done
