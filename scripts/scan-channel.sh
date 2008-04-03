#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=143
log "limit is ${CHANNEL_LIMIT}"

for item in standard cached local; do
    log "checking ${item}"
done
