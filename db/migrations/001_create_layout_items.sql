-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, level, ratio) VALUES (4, 17, 76.74);
INSERT INTO layout_items (count, level, ratio) VALUES (28, 51, 42.45);
INSERT INTO layout_items (count, level, ratio) VALUES (27, 40, 46.98);
