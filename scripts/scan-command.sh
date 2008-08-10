#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open local legacy latest; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=216
log "limit is ${COMMAND_LIMIT}"
