#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=39
log "limit is ${CHANNEL_LIMIT}"

for item in open green; do
    log "checking ${item}"
done
