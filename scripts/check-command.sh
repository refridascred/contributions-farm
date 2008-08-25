#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=357
log "limit is ${COMMAND_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
