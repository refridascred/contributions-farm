#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=500
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west green; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
