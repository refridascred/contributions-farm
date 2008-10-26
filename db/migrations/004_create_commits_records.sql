-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, ratio, label, owner, region) VALUES (12, 29.14, 'staging', 'stable', 'fallback');
INSERT INTO commits_records (level, ratio, label, owner, region) VALUES (5, 31.71, 'latest', 'strict', 'open');
