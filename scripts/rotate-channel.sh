#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=473
log "limit is ${CHANNEL_LIMIT}"

for item in cached latest eu-west primary; do
    log "checking ${item}"
done
