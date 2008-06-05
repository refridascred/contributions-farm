-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, rank, label, token, score) VALUES (44.25, 14, 'cached', 'strict', 95.09);
INSERT INTO commits_records (weight, rank, label, token, score) VALUES (43.97, 7, 'green', 'edge', 64.37);
INSERT INTO commits_records (weight, rank, label, token, score) VALUES (66.01, 87, 'stable', 'open', 10.66);
