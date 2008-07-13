#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=147
log "limit is ${CHANNEL_LIMIT}"
