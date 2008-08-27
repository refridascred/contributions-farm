-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, token, active, weight, label) VALUES (7.45, 'cached', 55, 61.98, 'eu-west');
INSERT INTO commits_records (ratio, token, active, weight, label) VALUES (56.36, 'open', 44, 91.5, 'blue');
