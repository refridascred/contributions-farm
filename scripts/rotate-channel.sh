#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=334
log "limit is ${CHANNEL_LIMIT}"

for item in standard cached fallback eu-west; do
    log "checking ${item}"
done
