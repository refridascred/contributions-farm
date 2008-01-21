#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict open legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=34
log "limit is ${CHANNEL_LIMIT}"
