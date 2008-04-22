-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, level, score) VALUES (31, 82, 74.44);
INSERT INTO layout_items (active, level, score) VALUES (20, 64, 85.32);
INSERT INTO layout_items (active, level, score) VALUES (39, 68, 27.44);
