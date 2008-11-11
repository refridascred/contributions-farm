#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback cached standard edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=321
log "limit is ${CHANNEL_LIMIT}"
