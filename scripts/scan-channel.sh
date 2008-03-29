#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=339
log "limit is ${CHANNEL_LIMIT}"

for item in legacy edge open; do
    log "checking ${item}"
done
