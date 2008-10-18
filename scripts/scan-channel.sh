#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached fallback green blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=318
log "limit is ${CHANNEL_LIMIT}"
