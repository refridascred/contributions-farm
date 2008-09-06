#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=379
log "limit is ${CHANNEL_LIMIT}"

for item in open cached local edge; do
    log "checking ${item}"
done
