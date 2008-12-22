#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=457
log "limit is ${CHANNEL_LIMIT}"
