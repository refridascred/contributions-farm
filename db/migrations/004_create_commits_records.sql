-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, owner, rank, ratio) VALUES ('edge', 'fallback', 25, 4.06);
INSERT INTO commits_records (state, owner, rank, ratio) VALUES ('open', 'open', 88, 21.04);
