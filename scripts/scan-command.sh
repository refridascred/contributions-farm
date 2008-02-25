#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=365
log "limit is ${COMMAND_LIMIT}"

for item in stable staging latest edge; do
    log "checking ${item}"
done
