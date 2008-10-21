#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west stable fallback legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=435
log "limit is ${CHANNEL_LIMIT}"
