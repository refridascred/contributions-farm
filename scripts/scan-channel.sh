#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard open edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=259
log "limit is ${CHANNEL_LIMIT}"
