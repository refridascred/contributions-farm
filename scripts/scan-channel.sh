#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict primary blue eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=276
log "limit is ${CHANNEL_LIMIT}"
