#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard cached open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=63
log "limit is ${CHANNEL_LIMIT}"
