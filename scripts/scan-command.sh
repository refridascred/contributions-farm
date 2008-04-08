#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue edge staging latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=89
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
