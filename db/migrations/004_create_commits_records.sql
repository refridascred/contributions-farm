-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, score, label) VALUES (61.23, 62.17, 'standard');
INSERT INTO commits_records (weight, score, label) VALUES (9.16, 5.17, 'open');
INSERT INTO commits_records (weight, score, label) VALUES (74.43, 26.15, 'green');
