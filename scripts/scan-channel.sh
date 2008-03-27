#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached edge; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=363
log "limit is ${CHANNEL_LIMIT}"
