#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=406
log "limit is ${CHANNEL_LIMIT}"

for item in legacy standard green primary; do
    log "checking ${item}"
done
