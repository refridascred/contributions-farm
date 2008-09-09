-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, count, label) VALUES (83.52, 27, 'green');
INSERT INTO commits_records (score, count, label) VALUES (65.33, 66, 'stable');
INSERT INTO commits_records (score, count, label) VALUES (60.36, 64, 'cached');
