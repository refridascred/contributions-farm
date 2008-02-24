#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local eu-west open primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=272
log "limit is ${CHANNEL_LIMIT}"
