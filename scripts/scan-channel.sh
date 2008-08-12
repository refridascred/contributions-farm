#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=102
log "limit is ${CHANNEL_LIMIT}"

for item in open latest local; do
    log "checking ${item}"
done
