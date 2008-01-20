#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=27
log "limit is ${CHANNEL_LIMIT}"

for item in edge green; do
    log "checking ${item}"
done
