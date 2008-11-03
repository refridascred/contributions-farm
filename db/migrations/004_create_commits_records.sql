-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, label, rank) VALUES (64, 'strict', 72);
INSERT INTO commits_records (active, label, rank) VALUES (36, 'latest', 21);
INSERT INTO commits_records (active, label, rank) VALUES (92, 'green', 77);
