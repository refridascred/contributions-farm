-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, active, state, level) VALUES (67, 86, 'standard', 55);
INSERT INTO commits_records (rank, active, state, level) VALUES (6, 53, 'latest', 98);
INSERT INTO commits_records (rank, active, state, level) VALUES (51, 20, 'fallback', 12);
