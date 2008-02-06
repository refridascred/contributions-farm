#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=398
log "limit is ${CHANNEL_LIMIT}"

for item in staging legacy; do
    log "checking ${item}"
done
