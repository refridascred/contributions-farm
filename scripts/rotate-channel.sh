#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=189
log "limit is ${CHANNEL_LIMIT}"

for item in open local primary; do
    log "checking ${item}"
done
