-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, count, label) VALUES (52.11, 97, 'stable');
INSERT INTO commits_records (ratio, count, label) VALUES (65.92, 69, 'blue');
INSERT INTO commits_records (ratio, count, label) VALUES (91.71, 41, 'standard');
