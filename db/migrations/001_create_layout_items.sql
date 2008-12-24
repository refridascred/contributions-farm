-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, active, level, score, owner) VALUES (1, 44, 39, 83.1, 'cached');
INSERT INTO layout_items (rank, active, level, score, owner) VALUES (63, 58, 57, 34.53, 'cached');
