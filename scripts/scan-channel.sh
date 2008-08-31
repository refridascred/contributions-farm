#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy fallback staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=149
log "limit is ${CHANNEL_LIMIT}"
