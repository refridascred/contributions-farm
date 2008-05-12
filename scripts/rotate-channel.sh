#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=332
log "limit is ${CHANNEL_LIMIT}"

for item in open primary fallback local; do
    log "checking ${item}"
done
