#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard blue primary open; do
    log "checking ${item}"
done

COMMAND_LIMIT=324
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
