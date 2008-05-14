#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=363
log "limit is ${CHANNEL_LIMIT}"
