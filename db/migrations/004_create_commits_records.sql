-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, ratio, weight) VALUES ('stable', 20.83, 10.94);
INSERT INTO commits_records (label, ratio, weight) VALUES ('fallback', 12.25, 37.03);
