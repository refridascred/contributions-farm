#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary standard eu-west cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=105
log "limit is ${CHANNEL_LIMIT}"
