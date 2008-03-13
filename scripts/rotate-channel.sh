#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=102
log "limit is ${CHANNEL_LIMIT}"

for item in local primary standard; do
    log "checking ${item}"
done
