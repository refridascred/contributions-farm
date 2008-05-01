#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west latest legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=46
log "limit is ${CHANNEL_LIMIT}"
