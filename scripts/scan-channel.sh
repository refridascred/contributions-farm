#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=381
log "limit is ${CHANNEL_LIMIT}"

for item in edge eu-west; do
    log "checking ${item}"
done
