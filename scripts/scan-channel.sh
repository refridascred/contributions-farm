#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=303
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
