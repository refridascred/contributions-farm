#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=35
log "limit is ${CHANNEL_LIMIT}"
