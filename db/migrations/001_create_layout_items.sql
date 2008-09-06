-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score, count) VALUES (55, 83.26, 89);
INSERT INTO layout_items (level, score, count) VALUES (34, 51.97, 29);
INSERT INTO layout_items (level, score, count) VALUES (62, 49.52, 28);
