#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=322
log "limit is ${COMMAND_LIMIT}"

for item in open strict fallback eu-west; do
    log "checking ${item}"
done
