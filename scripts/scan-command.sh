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

for item in strict blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=70
log "limit is ${COMMAND_LIMIT}"
