#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=499
log "limit is ${CHANNEL_LIMIT}"

for item in primary legacy local; do
    log "checking ${item}"
done
