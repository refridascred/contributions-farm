-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, ratio, rank, token, count) VALUES ('blue', 7.69, 77, 'blue', 52);
INSERT INTO commits_records (state, ratio, rank, token, count) VALUES ('eu-west', 77.0, 45, 'staging', 88);
