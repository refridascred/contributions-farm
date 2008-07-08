#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=407
log "limit is ${CHANNEL_LIMIT}"

for item in staging eu-west latest open; do
    log "checking ${item}"
done
