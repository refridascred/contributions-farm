-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, label, owner, ratio) VALUES (53, 'fallback', 'strict', 5.12);
INSERT INTO commits_records (rank, label, owner, ratio) VALUES (83, 'staging', 'blue', 68.37);
