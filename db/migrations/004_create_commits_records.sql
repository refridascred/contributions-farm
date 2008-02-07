-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, ratio, weight, active, region) VALUES ('open', 46.46, 61.27, 53, 'fallback');
INSERT INTO commits_records (label, ratio, weight, active, region) VALUES ('standard', 40.45, 46.64, 51, 'green');
