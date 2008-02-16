#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=273
log "limit is ${CHANNEL_LIMIT}"

for item in green latest standard; do
    log "checking ${item}"
done
