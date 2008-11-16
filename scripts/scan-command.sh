#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open local; do
    log "checking ${item}"
done

COMMAND_LIMIT=28
log "limit is ${COMMAND_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
