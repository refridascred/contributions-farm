#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open stable legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=101
log "limit is ${COMMAND_LIMIT}"
