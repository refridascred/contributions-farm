#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict green staging latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=292
log "limit is ${CHANNEL_LIMIT}"
