#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=90
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open strict blue; do
    log "checking ${item}"
done
