-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, region, token, active, label) VALUES (4.21, 'eu-west', 'green', 45, 'staging');
INSERT INTO commits_records (weight, region, token, active, label) VALUES (77.31, 'cached', 'open', 58, 'stable');
INSERT INTO commits_records (weight, region, token, active, label) VALUES (28.57, 'edge', 'edge', 71, 'legacy');
