-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, token, ratio, label, region) VALUES (21, 'standard', 42.62, 'primary', 'green');
INSERT INTO commits_records (active, token, ratio, label, region) VALUES (72, 'primary', 12.23, 'eu-west', 'cached');
