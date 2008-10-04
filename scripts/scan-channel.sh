#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=227
log "limit is ${CHANNEL_LIMIT}"
