#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached legacy eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=216
log "limit is ${CHANNEL_LIMIT}"
