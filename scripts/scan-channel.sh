#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=173
log "limit is ${CHANNEL_LIMIT}"

for item in local latest edge legacy; do
    log "checking ${item}"
done
