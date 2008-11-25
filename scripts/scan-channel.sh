#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green stable local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=446
log "limit is ${CHANNEL_LIMIT}"
