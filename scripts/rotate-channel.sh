#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=77
log "limit is ${CHANNEL_LIMIT}"

for item in legacy cached blue; do
    log "checking ${item}"
done
