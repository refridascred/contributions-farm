#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local eu-west blue legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=57
log "limit is ${CHANNEL_LIMIT}"
