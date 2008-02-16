#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=273
log "limit is ${CHANNEL_LIMIT}"

for item in latest cached green; do
    log "checking ${item}"
done
