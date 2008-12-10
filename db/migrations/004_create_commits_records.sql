-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, token, rank, score, label) VALUES (16, 'open', 7, 14.12, 'open');
INSERT INTO commits_records (count, token, rank, score, label) VALUES (52, 'cached', 37, 68.55, 'edge');
INSERT INTO commits_records (count, token, rank, score, label) VALUES (65, 'standard', 0, 96.01, 'standard');
