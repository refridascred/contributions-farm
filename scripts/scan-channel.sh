#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=113
log "limit is ${CHANNEL_LIMIT}"

for item in fallback strict local edge; do
    log "checking ${item}"
done
