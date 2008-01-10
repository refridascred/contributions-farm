-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, rank, count, level, owner) VALUES (6.9, 30, 84, 83, 'fallback');
INSERT INTO layout_items (score, rank, count, level, owner) VALUES (68.41, 17, 66, 65, 'open');
