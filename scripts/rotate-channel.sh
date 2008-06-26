#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=253
log "limit is ${CHANNEL_LIMIT}"

for item in cached primary eu-west legacy; do
    log "checking ${item}"
done
