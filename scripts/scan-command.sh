#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=282
log "limit is ${COMMAND_LIMIT}"

for item in strict edge local staging; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
