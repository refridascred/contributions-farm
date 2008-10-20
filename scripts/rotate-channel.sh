#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=266
log "limit is ${CHANNEL_LIMIT}"

for item in legacy cached edge strict; do
    log "checking ${item}"
done
