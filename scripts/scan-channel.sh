#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest cached edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=79
log "limit is ${CHANNEL_LIMIT}"
