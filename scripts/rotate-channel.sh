#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=465
log "limit is ${CHANNEL_LIMIT}"
