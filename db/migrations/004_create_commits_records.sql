-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, rank, weight, token) VALUES ('green', 98, 42.46, 'latest');
INSERT INTO commits_records (label, rank, weight, token) VALUES ('cached', 42, 45.37, 'edge');
