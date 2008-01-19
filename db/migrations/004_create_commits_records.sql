-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, rank, count) VALUES ('eu-west', 72, 21);
INSERT INTO commits_records (label, rank, count) VALUES ('cached', 14, 31);
INSERT INTO commits_records (label, rank, count) VALUES ('primary', 33, 94);
