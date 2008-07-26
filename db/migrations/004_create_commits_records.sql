-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, label, rank, count, weight) VALUES (69.29, 'eu-west', 26, 62, 28.57);
INSERT INTO commits_records (score, label, rank, count, weight) VALUES (72.2, 'edge', 71, 50, 82.1);
