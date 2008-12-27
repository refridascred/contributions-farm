-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, count, weight, token, label) VALUES (70, 8, 12.53, 'local', 'blue');
INSERT INTO commits_records (rank, count, weight, token, label) VALUES (21, 36, 83.86, 'local', 'edge');
INSERT INTO commits_records (rank, count, weight, token, label) VALUES (21, 23, 63.62, 'latest', 'blue');
