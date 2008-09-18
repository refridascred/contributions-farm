#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=153
log "limit is ${CHANNEL_LIMIT}"

for item in open latest blue edge; do
    log "checking ${item}"
done
