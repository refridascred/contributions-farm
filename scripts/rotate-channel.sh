#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=428
log "limit is ${CHANNEL_LIMIT}"

for item in edge cached fallback staging; do
    log "checking ${item}"
done
