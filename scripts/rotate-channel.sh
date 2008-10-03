#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary legacy cached local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=416
log "limit is ${CHANNEL_LIMIT}"
