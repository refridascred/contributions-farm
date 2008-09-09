#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging fallback standard local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=281
log "limit is ${CHANNEL_LIMIT}"
