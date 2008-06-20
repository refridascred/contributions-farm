#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard strict eu-west stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=264
log "limit is ${COMMAND_LIMIT}"
