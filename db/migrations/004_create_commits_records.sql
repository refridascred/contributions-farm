-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, score, token, ratio) VALUES (14, 81.52, 'strict', 85.78);
INSERT INTO commits_records (active, score, token, ratio) VALUES (3, 37.23, 'green', 45.47);
