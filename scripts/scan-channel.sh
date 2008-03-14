#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=443
log "limit is ${CHANNEL_LIMIT}"

for item in staging eu-west; do
    log "checking ${item}"
done
