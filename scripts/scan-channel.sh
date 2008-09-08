#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=492
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west latest cached legacy; do
    log "checking ${item}"
done
