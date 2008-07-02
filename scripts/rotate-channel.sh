#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback cached primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=244
log "limit is ${CHANNEL_LIMIT}"
