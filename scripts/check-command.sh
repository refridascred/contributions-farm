#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west strict legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=169
log "limit is ${COMMAND_LIMIT}"
