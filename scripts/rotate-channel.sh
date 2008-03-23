#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=77
log "limit is ${CHANNEL_LIMIT}"
