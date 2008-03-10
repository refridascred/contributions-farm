-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, rank, owner, level) VALUES (0.67, 34, 'blue', 89);
INSERT INTO layout_items (ratio, rank, owner, level) VALUES (73.31, 22, 'fallback', 30);
