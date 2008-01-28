#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict edge eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=156
log "limit is ${CHANNEL_LIMIT}"
