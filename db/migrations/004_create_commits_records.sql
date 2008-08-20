-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, rank, level, owner, active) VALUES ('fallback', 15, 57, 'stable', 98);
INSERT INTO commits_records (state, rank, level, owner, active) VALUES ('strict', 67, 16, 'staging', 5);
