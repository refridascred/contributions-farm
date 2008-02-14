#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=79
log "limit is ${COMMAND_LIMIT}"
