#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=216
log "limit is ${CHANNEL_LIMIT}"

for item in strict latest; do
    log "checking ${item}"
done
