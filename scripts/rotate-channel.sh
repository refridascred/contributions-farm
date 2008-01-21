#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=176
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback standard primary; do
    log "checking ${item}"
done
