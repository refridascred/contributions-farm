-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, token, label, rank) VALUES (56, 'primary', 'latest', 6);
INSERT INTO commits_records (active, token, label, rank) VALUES (28, 'latest', 'legacy', 71);
INSERT INTO commits_records (active, token, label, rank) VALUES (17, 'blue', 'stable', 45);
