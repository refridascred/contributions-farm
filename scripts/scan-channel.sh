#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=78
log "limit is ${CHANNEL_LIMIT}"

for item in fallback edge open; do
    log "checking ${item}"
done
