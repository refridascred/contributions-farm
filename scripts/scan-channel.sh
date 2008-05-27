#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=28
log "limit is ${CHANNEL_LIMIT}"

for item in open strict primary green; do
    log "checking ${item}"
done
