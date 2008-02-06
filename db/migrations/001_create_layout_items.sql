-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, level, ratio) VALUES (27, 24, 85.7);
INSERT INTO layout_items (active, level, ratio) VALUES (47, 37, 52.52);
INSERT INTO layout_items (active, level, ratio) VALUES (77, 78, 73.74);
