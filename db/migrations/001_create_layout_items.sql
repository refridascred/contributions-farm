-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, weight, ratio, count) VALUES (56, 80.91, 75.14, 25);
INSERT INTO layout_items (level, weight, ratio, count) VALUES (33, 73.55, 35.52, 28);
