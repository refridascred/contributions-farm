#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy latest eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=400
log "limit is ${CHANNEL_LIMIT}"
