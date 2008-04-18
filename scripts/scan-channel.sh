#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=352
log "limit is ${CHANNEL_LIMIT}"

for item in stable strict eu-west; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
