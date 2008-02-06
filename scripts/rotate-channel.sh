#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green cached standard latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=469
log "limit is ${CHANNEL_LIMIT}"
