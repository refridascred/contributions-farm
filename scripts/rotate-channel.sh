#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard latest blue strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=111
log "limit is ${CHANNEL_LIMIT}"
