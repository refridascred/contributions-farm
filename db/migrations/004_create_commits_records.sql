-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, label, weight, token) VALUES ('standard', 'green', 14.65, 'local');
INSERT INTO commits_records (region, label, weight, token) VALUES ('cached', 'open', 36.46, 'standard');
INSERT INTO commits_records (region, label, weight, token) VALUES ('green', 'staging', 58.64, 'strict');
