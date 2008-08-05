-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, token, score, owner, weight) VALUES ('legacy', 'legacy', 92.67, 'cached', 50.31);
INSERT INTO commits_records (label, token, score, owner, weight) VALUES ('blue', 'green', 44.13, 'open', 59.22);
