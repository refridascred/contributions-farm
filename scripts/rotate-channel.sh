#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=122
log "limit is ${CHANNEL_LIMIT}"

for item in primary legacy standard edge; do
    log "checking ${item}"
done
