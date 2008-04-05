-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, weight, label) VALUES (16.93, 64.95, 'standard');
INSERT INTO commits_records (ratio, weight, label) VALUES (25.49, 73.24, 'fallback');
