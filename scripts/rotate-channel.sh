#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=110
log "limit is ${CHANNEL_LIMIT}"

for item in strict fallback; do
    log "checking ${item}"
done
