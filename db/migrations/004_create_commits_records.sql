-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, rank, count, label) VALUES ('latest', 31, 14, 'open');
INSERT INTO commits_records (token, rank, count, label) VALUES ('primary', 2, 92, 'standard');
