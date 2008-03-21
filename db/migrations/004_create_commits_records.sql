-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, owner, level, count) VALUES ('fallback', 'primary', 18, 70);
INSERT INTO commits_records (state, owner, level, count) VALUES ('strict', 'fallback', 60, 90);
INSERT INTO commits_records (state, owner, level, count) VALUES ('green', 'fallback', 97, 94);
