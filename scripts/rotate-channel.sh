#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=116
log "limit is ${CHANNEL_LIMIT}"

for item in stable staging primary; do
    log "checking ${item}"
done
