#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=435
log "limit is ${CHANNEL_LIMIT}"

for item in strict edge; do
    log "checking ${item}"
done
