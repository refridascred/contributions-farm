#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=106
log "limit is ${CHANNEL_LIMIT}"
