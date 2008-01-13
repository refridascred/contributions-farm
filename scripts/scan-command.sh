#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict open; do
    log "checking ${item}"
done

COMMAND_LIMIT=396
log "limit is ${COMMAND_LIMIT}"
