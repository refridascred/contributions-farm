#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open staging cached standard; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=497
log "limit is ${COMMAND_LIMIT}"
