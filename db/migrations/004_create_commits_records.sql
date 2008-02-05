-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, label, owner) VALUES (89.08, 54.46, 'primary', 'green');
INSERT INTO commits_records (score, ratio, label, owner) VALUES (57.96, 6.91, 'strict', 'open');
INSERT INTO commits_records (score, ratio, label, owner) VALUES (44.3, 29.23, 'fallback', 'staging');
