-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, count, label) VALUES (84.14, 61, 'stable');
INSERT INTO commits_records (ratio, count, label) VALUES (38.48, 89, 'strict');
INSERT INTO commits_records (ratio, count, label) VALUES (36.63, 79, 'staging');
