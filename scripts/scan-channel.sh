#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=475
log "limit is ${CHANNEL_LIMIT}"

for item in local strict; do
    log "checking ${item}"
done
