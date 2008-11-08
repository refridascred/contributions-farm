-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, level, count) VALUES ('stable', 65, 39);
INSERT INTO commits_records (state, level, count) VALUES ('strict', 10, 81);
INSERT INTO commits_records (state, level, count) VALUES ('staging', 63, 22);
