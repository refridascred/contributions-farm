#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=81
log "limit is ${CHANNEL_LIMIT}"
