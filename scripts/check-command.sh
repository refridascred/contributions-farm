#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=89
log "limit is ${COMMAND_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest primary cached edge; do
    log "checking ${item}"
done
