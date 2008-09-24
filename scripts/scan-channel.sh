#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=130
log "limit is ${CHANNEL_LIMIT}"

for item in cached open fallback edge; do
    log "checking ${item}"
done
