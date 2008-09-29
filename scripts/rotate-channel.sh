#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=395
log "limit is ${CHANNEL_LIMIT}"

for item in blue eu-west open; do
    log "checking ${item}"
done
