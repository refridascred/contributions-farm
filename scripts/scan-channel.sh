#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=185
log "limit is ${CHANNEL_LIMIT}"

for item in open green; do
    log "checking ${item}"
done
