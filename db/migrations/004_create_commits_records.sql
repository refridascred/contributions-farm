-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, weight, owner, rank, score) VALUES ('blue', 89.36, 'eu-west', 72, 63.93);
INSERT INTO commits_records (label, weight, owner, rank, score) VALUES ('open', 0.2, 'local', 64, 42.52);
