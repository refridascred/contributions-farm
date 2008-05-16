#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict standard legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=216
log "limit is ${CHANNEL_LIMIT}"
