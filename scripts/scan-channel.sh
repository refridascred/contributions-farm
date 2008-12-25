#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=57
log "limit is ${CHANNEL_LIMIT}"

for item in blue standard staging; do
    log "checking ${item}"
done
