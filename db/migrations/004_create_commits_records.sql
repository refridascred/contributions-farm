-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, rank, label, level) VALUES ('cached', 19, 'stable', 37);
INSERT INTO commits_records (owner, rank, label, level) VALUES ('fallback', 15, 'standard', 42);
INSERT INTO commits_records (owner, rank, label, level) VALUES ('stable', 59, 'open', 32);
