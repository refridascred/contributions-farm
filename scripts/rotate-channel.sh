#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=172
log "limit is ${CHANNEL_LIMIT}"

for item in strict stable local cached; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
