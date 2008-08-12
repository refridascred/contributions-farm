#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=166
log "limit is ${CHANNEL_LIMIT}"

for item in primary eu-west cached fallback; do
    log "checking ${item}"
done
