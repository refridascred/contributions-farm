#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=148
log "limit is ${CHANNEL_LIMIT}"

for item in staging blue edge cached; do
    log "checking ${item}"
done
