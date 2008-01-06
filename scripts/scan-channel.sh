#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback local staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=381
log "limit is ${CHANNEL_LIMIT}"
