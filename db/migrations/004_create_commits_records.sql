-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, label, score) VALUES (21, 34, 'staging', 77.59);
INSERT INTO commits_records (rank, level, label, score) VALUES (13, 37, 'eu-west', 12.5);
INSERT INTO commits_records (rank, level, label, score) VALUES (11, 11, 'local', 51.12);
