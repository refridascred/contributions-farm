#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest staging cached legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=420
log "limit is ${CHANNEL_LIMIT}"
