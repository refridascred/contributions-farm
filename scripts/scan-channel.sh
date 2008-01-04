#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=196
log "limit is ${CHANNEL_LIMIT}"

for item in strict legacy stable; do
    log "checking ${item}"
done
