-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, score, label, ratio) VALUES ('staging', 7.27, 'standard', 61.92);
INSERT INTO commits_records (state, score, label, ratio) VALUES ('fallback', 25.11, 'latest', 5.18);
