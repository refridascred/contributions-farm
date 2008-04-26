#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=321
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west staging; do
    log "checking ${item}"
done
