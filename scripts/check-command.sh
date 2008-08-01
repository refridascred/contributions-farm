#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west standard stable; do
    log "checking ${item}"
done

mode="${1:-standard}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=248
log "limit is ${COMMAND_LIMIT}"
