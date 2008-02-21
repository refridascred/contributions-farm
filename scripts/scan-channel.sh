#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=371
log "limit is ${CHANNEL_LIMIT}"

for item in cached standard local stable; do
    log "checking ${item}"
done
