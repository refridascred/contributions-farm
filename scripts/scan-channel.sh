#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=279
log "limit is ${CHANNEL_LIMIT}"

for item in green cached; do
    log "checking ${item}"
done
