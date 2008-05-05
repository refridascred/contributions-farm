-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, score, level, owner, rank) VALUES (55.08, 16.52, 52, 'open', 2);
INSERT INTO layout_items (ratio, score, level, owner, rank) VALUES (3.7, 49.89, 78, 'local', 31);
