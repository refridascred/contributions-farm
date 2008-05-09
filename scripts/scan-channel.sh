#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge staging cached legacy; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=253
log "limit is ${CHANNEL_LIMIT}"
