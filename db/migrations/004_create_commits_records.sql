-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, ratio, label, token) VALUES (4.98, 18.62, 'local', 'edge');
INSERT INTO commits_records (weight, ratio, label, token) VALUES (58.44, 44.23, 'cached', 'edge');
