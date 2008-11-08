#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable green cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=370
log "limit is ${CHANNEL_LIMIT}"
