-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, region, state, score, ratio) VALUES (0, 'local', 'fallback', 84.6, 68.66);
INSERT INTO commits_records (count, region, state, score, ratio) VALUES (60, 'primary', 'staging', 36.45, 39.2);
