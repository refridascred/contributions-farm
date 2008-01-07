#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest primary legacy fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=377
log "limit is ${CHANNEL_LIMIT}"
