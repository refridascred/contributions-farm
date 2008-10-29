-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, owner, ratio, active, count) VALUES ('blue', 'open', 17.6, 99, 27);
INSERT INTO commits_records (state, owner, ratio, active, count) VALUES ('open', 'staging', 90.77, 45, 36);
INSERT INTO commits_records (state, owner, ratio, active, count) VALUES ('primary', 'latest', 33.9, 18, 93);
