#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=350
log "limit is ${CHANNEL_LIMIT}"

for item in blue strict legacy standard; do
    log "checking ${item}"
done
