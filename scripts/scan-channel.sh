#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback standard edge primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=236
log "limit is ${CHANNEL_LIMIT}"
