#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=198
log "limit is ${CHANNEL_LIMIT}"

for item in open strict fallback; do
    log "checking ${item}"
done
