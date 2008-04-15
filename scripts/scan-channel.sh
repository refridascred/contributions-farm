#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=351
log "limit is ${CHANNEL_LIMIT}"

for item in legacy latest local staging; do
    log "checking ${item}"
done
