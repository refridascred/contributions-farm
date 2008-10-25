#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=468
log "limit is ${CHANNEL_LIMIT}"

for item in latest edge eu-west legacy; do
    log "checking ${item}"
done
