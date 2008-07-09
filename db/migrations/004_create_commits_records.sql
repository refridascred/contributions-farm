-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, token, label, rank, count) VALUES (69.47, 'fallback', 'standard', 86, 71);
INSERT INTO commits_records (score, token, label, rank, count) VALUES (42.71, 'blue', 'standard', 40, 4);
