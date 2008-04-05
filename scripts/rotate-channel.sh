#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=426
log "limit is ${CHANNEL_LIMIT}"

for item in edge open; do
    log "checking ${item}"
done
