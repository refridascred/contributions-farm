#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open staging stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=394
log "limit is ${CHANNEL_LIMIT}"
