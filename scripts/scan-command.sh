#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard fallback stable strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=484
log "limit is ${COMMAND_LIMIT}"
