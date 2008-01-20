#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=103
log "limit is ${COMMAND_LIMIT}"

for item in legacy strict green edge; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
