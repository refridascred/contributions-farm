#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=352
log "limit is ${CHANNEL_LIMIT}"

for item in cached primary; do
    log "checking ${item}"
done
