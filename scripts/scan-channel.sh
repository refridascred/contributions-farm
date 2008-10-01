#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict latest blue fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=73
log "limit is ${CHANNEL_LIMIT}"
