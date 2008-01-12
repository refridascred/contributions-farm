#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=98
log "limit is ${COMMAND_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
