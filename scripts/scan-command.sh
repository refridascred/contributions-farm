#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=120
log "limit is ${COMMAND_LIMIT}"

for item in primary edge strict blue; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
