#!/usr/bin/env bash
# Check the command data.
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

for item in staging eu-west local; do
    log "checking ${item}"
done

COMMAND_LIMIT=207
log "limit is ${COMMAND_LIMIT}"
