#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=300
log "limit is ${CHANNEL_LIMIT}"

for item in cached standard; do
    log "checking ${item}"
done
