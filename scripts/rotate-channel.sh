#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge latest fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=255
log "limit is ${CHANNEL_LIMIT}"
