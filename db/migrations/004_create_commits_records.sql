-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, weight, count) VALUES ('open', 96.13, 3);
INSERT INTO commits_records (label, weight, count) VALUES ('latest', 2.83, 32);
