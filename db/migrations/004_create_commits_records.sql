-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, state, rank) VALUES ('edge', 12, 'stable', 74);
INSERT INTO commits_records (region, active, state, rank) VALUES ('staging', 10, 'green', 14);
INSERT INTO commits_records (region, active, state, rank) VALUES ('legacy', 55, 'standard', 14);
