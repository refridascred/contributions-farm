#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=180
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
