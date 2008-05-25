#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=408
log "limit is ${CHANNEL_LIMIT}"

for item in legacy cached fallback; do
    log "checking ${item}"
done
