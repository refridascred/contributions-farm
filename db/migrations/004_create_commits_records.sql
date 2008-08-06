-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, count, level, label) VALUES (0, 91, 98, 'eu-west');
INSERT INTO commits_records (rank, count, level, label) VALUES (48, 23, 7, 'eu-west');
INSERT INTO commits_records (rank, count, level, label) VALUES (6, 97, 41, 'eu-west');
