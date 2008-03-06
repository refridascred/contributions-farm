#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy cached local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=427
log "limit is ${CHANNEL_LIMIT}"
