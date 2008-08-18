-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, weight, active, region) VALUES ('standard', 27.37, 2, 'strict');
INSERT INTO commits_records (label, weight, active, region) VALUES ('standard', 23.07, 2, 'eu-west');
