#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=96
log "limit is ${COMMAND_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
