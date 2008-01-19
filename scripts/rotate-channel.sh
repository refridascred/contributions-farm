#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green cached latest primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=439
log "limit is ${CHANNEL_LIMIT}"
