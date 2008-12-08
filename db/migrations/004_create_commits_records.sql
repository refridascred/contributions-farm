-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, active, region, count, label) VALUES (65.44, 72, 'strict', 58, 'open');
INSERT INTO commits_records (score, active, region, count, label) VALUES (44.09, 99, 'strict', 26, 'local');
