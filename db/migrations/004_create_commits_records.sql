-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, label, count, token) VALUES (49.21, 'stable', 62, 'stable');
INSERT INTO commits_records (ratio, label, count, token) VALUES (56.99, 'strict', 29, 'standard');
INSERT INTO commits_records (ratio, label, count, token) VALUES (61.16, 'strict', 81, 'strict');
