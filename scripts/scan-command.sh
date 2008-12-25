#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=63
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
