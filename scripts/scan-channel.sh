#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west open stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=428
log "limit is ${CHANNEL_LIMIT}"
