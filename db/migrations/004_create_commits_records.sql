-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, active, level, ratio) VALUES ('latest', 50, 63, 14.82);
INSERT INTO commits_records (state, active, level, ratio) VALUES ('strict', 57, 44, 27.06);
INSERT INTO commits_records (state, active, level, ratio) VALUES ('strict', 27, 45, 6.17);
