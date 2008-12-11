#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary local; do
    log "checking ${item}"
done

COMMAND_LIMIT=391
log "limit is ${COMMAND_LIMIT}"
