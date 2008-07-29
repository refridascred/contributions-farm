-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, level, rank, active) VALUES ('fallback', 12, 97, 29);
INSERT INTO commits_records (state, level, rank, active) VALUES ('legacy', 94, 11, 48);
INSERT INTO commits_records (state, level, rank, active) VALUES ('cached', 48, 55, 14);
