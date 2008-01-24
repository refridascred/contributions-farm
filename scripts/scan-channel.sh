#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=63
log "limit is ${CHANNEL_LIMIT}"

for item in blue green latest; do
    log "checking ${item}"
done
