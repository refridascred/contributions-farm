-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, count, level) VALUES (56.95, 56, 7);
INSERT INTO layout_items (ratio, count, level) VALUES (97.33, 64, 90);
INSERT INTO layout_items (ratio, count, level) VALUES (22.9, 54, 78);
