#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard local; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=237
log "limit is ${CHANNEL_LIMIT}"
