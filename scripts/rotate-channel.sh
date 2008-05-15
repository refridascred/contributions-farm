#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=163
log "limit is ${CHANNEL_LIMIT}"

for item in latest eu-west cached stable; do
    log "checking ${item}"
done
