#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=348
log "limit is ${COMMAND_LIMIT}"

for item in strict fallback blue; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
