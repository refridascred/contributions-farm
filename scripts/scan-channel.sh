#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=82
log "limit is ${CHANNEL_LIMIT}"

for item in green edge latest; do
    log "checking ${item}"
done
