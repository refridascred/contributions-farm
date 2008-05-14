#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open cached green; do
    log "checking ${item}"
done

COMMAND_LIMIT=73
log "limit is ${COMMAND_LIMIT}"
