#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard local strict eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=298
log "limit is ${CHANNEL_LIMIT}"
