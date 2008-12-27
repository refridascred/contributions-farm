#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=381
log "limit is ${CHANNEL_LIMIT}"

for item in green blue cached; do
    log "checking ${item}"
done
