#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=416
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west stable strict primary; do
    log "checking ${item}"
done
