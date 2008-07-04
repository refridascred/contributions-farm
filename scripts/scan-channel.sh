#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest legacy primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=116
log "limit is ${CHANNEL_LIMIT}"
