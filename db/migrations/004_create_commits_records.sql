-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, level, count, owner) VALUES ('green', 90, 37, 'eu-west');
INSERT INTO commits_records (state, level, count, owner) VALUES ('open', 88, 7, 'open');
INSERT INTO commits_records (state, level, count, owner) VALUES ('primary', 5, 3, 'cached');
