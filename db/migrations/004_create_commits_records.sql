-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, ratio, token, count, rank) VALUES ('green', 90.61, 'latest', 40, 27);
INSERT INTO commits_records (state, ratio, token, count, rank) VALUES ('standard', 1.18, 'eu-west', 9, 81);
