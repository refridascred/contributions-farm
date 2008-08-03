-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, ratio, label, state) VALUES (96.27, 35.54, 'fallback', 'eu-west');
INSERT INTO commits_records (weight, ratio, label, state) VALUES (57.83, 44.47, 'staging', 'staging');
