#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=181
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
