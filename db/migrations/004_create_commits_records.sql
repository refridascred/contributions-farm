-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, rank, score) VALUES ('eu-west', 13, 37.4);
INSERT INTO commits_records (label, rank, score) VALUES ('cached', 23, 66.48);
INSERT INTO commits_records (label, rank, score) VALUES ('primary', 32, 42.12);
