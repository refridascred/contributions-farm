-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, owner) VALUES (95.29, 'eu-west', 'local');
INSERT INTO commits_records (weight, label, owner) VALUES (5.59, 'eu-west', 'strict');
