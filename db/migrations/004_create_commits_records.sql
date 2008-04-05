-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, token) VALUES (14.98, 'strict', 'stable');
INSERT INTO commits_records (weight, label, token) VALUES (57.94, 'edge', 'cached');
INSERT INTO commits_records (weight, label, token) VALUES (55.89, 'cached', 'stable');
