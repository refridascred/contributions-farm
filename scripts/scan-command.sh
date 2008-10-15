#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue legacy open; do
    log "checking ${item}"
done

COMMAND_LIMIT=311
log "limit is ${COMMAND_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
