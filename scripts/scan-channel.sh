#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=219
log "limit is ${CHANNEL_LIMIT}"

for item in open blue stable staging; do
    log "checking ${item}"
done
