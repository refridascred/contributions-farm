-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, token, count, ratio) VALUES ('staging', 'cached', 11, 14.93);
INSERT INTO commits_records (label, token, count, ratio) VALUES ('fallback', 'standard', 89, 43.31);
