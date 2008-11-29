#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=348
log "limit is ${CHANNEL_LIMIT}"
