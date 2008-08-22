#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=427
log "limit is ${CHANNEL_LIMIT}"

for item in staging standard blue green; do
    log "checking ${item}"
done
