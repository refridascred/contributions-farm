#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=12
log "limit is ${CHANNEL_LIMIT}"

for item in primary blue latest eu-west; do
    log "checking ${item}"
done
