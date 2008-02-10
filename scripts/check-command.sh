#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy open local; do
    log "checking ${item}"
done

COMMAND_LIMIT=26
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
