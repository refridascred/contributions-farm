-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, count, active, rank, ratio) VALUES ('legacy', 75, 52, 37, 83.69);
INSERT INTO commits_records (state, count, active, rank, ratio) VALUES ('strict', 42, 68, 32, 78.65);
INSERT INTO commits_records (state, count, active, rank, ratio) VALUES ('local', 27, 96, 32, 91.75);
