-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, token, label, level) VALUES (84.33, 'primary', 'open', 91);
INSERT INTO commits_records (weight, token, label, level) VALUES (17.36, 'primary', 'local', 70);
