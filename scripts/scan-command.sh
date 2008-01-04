#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=428
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest fallback strict; do
    log "checking ${item}"
done
