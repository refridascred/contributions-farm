#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=80
log "limit is ${CHANNEL_LIMIT}"

for item in local latest; do
    log "checking ${item}"
done
