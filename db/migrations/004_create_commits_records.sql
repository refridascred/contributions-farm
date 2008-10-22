-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, label, count, score, region) VALUES ('standard', 'fallback', 20, 53.29, 'green');
INSERT INTO commits_records (owner, label, count, score, region) VALUES ('latest', 'edge', 17, 13.1, 'primary');
