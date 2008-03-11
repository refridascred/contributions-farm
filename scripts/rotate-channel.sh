#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=159
log "limit is ${CHANNEL_LIMIT}"
