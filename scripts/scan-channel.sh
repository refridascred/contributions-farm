#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached primary green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=470
log "limit is ${CHANNEL_LIMIT}"
