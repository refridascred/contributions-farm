#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=219
log "limit is ${CHANNEL_LIMIT}"
