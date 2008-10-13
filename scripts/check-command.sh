#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard primary fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=373
log "limit is ${COMMAND_LIMIT}"
