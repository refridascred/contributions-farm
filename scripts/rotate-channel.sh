#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open latest local primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=409
log "limit is ${CHANNEL_LIMIT}"
