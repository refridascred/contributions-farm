#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open stable cached latest; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=276
log "limit is ${CHANNEL_LIMIT}"
