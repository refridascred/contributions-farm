-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, state, owner, level) VALUES (27, 'cached', 'primary', 95);
INSERT INTO commits_records (rank, state, owner, level) VALUES (50, 'open', 'legacy', 18);
INSERT INTO commits_records (rank, state, owner, level) VALUES (12, 'fallback', 'stable', 59);
