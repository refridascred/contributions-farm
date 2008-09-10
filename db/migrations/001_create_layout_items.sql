-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, ratio) VALUES (54, 93.44);
INSERT INTO layout_items (level, ratio) VALUES (94, 32.3);
INSERT INTO layout_items (level, ratio) VALUES (4, 47.47);
