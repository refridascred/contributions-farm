#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=97
log "limit is ${CHANNEL_LIMIT}"

for item in primary latest cached; do
    log "checking ${item}"
done
