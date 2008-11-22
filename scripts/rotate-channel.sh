#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached staging primary legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=405
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
